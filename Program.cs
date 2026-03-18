class Program
{
    static void Main()
    {   
        RentalService service = new RentalService();
        Student student1 = new Student(1, "Roman", "Klimovich");
        Employee employee1 = new Employee(2, "Anna", "Nowak");

        Console.WriteLine($"Student: {student1.FirstName} {student1.LastName}, Max Rentals: {student1.MaxRentals}");
        Console.WriteLine($"Employee: {employee1.FirstName} {employee1.LastName}, Max Rentals: {employee1.MaxRentals}");

        DataStore.Users.Add(student1);
        DataStore.Users.Add(employee1);

        Laptop laptop = new Laptop(1, "Dell", "i7", 16);
        Projector projector = new Projector(2, "Epson", 1500, true);

        DataStore.Equipment.Add(laptop);
        DataStore.Equipment.Add(projector);

        service.RentEquipment(student1, laptop, 3);

        Console.WriteLine("Laptop rented successfully.");

        try
        {
            service.RentEquipment(student1, projector, 3);
            service.RentEquipment(student1, laptop, 3);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
