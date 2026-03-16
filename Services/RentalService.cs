public class RentalService
{
    public void RentEquipment(User user, Equipment equipment, int days)
    {
        if (!equipment.IsAvailable)
        {
            throw new Exception("Equipment is not available for rent.");
        }

        int activeRentals = DataStore.Rentals.Count(r => r.user.Id == user.Id && !r.IsReturned);

        if (activeRentals >= user.MaxRentals)
        {
            throw new Exception("User has reached the maximum number of active rentals.");
        }

        Rental rental = new Rental
        {
            user = user,
            equipment = equipment,
            rentalDate = DateTime.Now,
            dueDate = DateTime.Now.AddDays(days),
            penalty = 0
        };

        equipment.IsAvailable = false;
        DataStore.Rentals.Add(rental);
    }

    public void ReturnEquipment(Rental rental)
    {
        rental.returnDate = DateTime.Now;

        if (rental.returnDate > rental.dueDate)
        {
            int lateDays = (rental.returnDate.Value - rental.dueDate).Days;
            rental.penalty = lateDuration.TotalDays * 5; // Example penalty calculation
        }

        rental.equipment.IsAvailable = true;
    } 

}