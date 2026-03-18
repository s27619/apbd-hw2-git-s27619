public class RentalService
{
    public void RentEquipment(User user, Equipment equipment, int days)
    {
        if (!equipment.IsAvailable)
        {
            throw new Exception("Equipment is not available for rent.");
        }

        int activeRentals = DataStore.Rentals.Count(r => r.User.Id == user.Id && !r.IsReturned);

        if (activeRentals >= user.MaxRentals)
        {
            throw new Exception("User has reached the maximum number of active rentals.");
        }

        Rental rental = new Rental
        {
            User = user,
            Equipment = equipment,
            RentalDate = DateTime.Now,
            DueDate = DateTime.Now.AddDays(days),
            Penalty = 0
        };

        equipment.IsAvailable = false;
        DataStore.Rentals.Add(rental);
    }

    public void ReturnEquipment(Rental rental)
    {
        rental.ReturnDate = DateTime.Now;

        if (rental.ReturnDate > rental.DueDate)
        {
            int lateDays = (rental.ReturnDate.Value - rental.DueDate).Days;
            rental.Penalty = lateDays * 5; // penalty calculation
        }

        rental.Equipment.IsAvailable = true;
    } 

    public List<Rental> GetOverdueRentals()
    {
        return DataStore.Rentals.Where(r => !r.IsReturned && r.DueDate < DateTime.Now).ToList();
    }

}