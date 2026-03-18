class Program
{

    static void Main()
    {
        RentalService service = new RentalService();

        // Sample data
        var student = new Student(1, "Roman", "Klimovich");
        var employee = new Employee(2, "Anna", "Nowak");

        DataStore.Users.Add(student);
            DataStore.Users.Add(employee);

            var laptop = new Laptop(1, "Dell", "i7", 16);
            var projector = new Projector(2, "Epson", 1500, true);

            DataStore.Equipment.Add(laptop);
            DataStore.Equipment.Add(projector);

            while (true)
            {
                Console.WriteLine("\n===== RENTAL SYSTEM =====");
                Console.WriteLine("1. Show Users");
                Console.WriteLine("2. Show Equipment");
                Console.WriteLine("3. Rent Equipment");
                Console.WriteLine("4. Show Overdue Rentals");
                Console.WriteLine("0. Exit");
                Console.Write("Choose option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ShowUsers();
                        break;

                    case "2":
                        ShowEquipment();
                        break;

                    case "3":
                        RentEquipment(service);
                        break;

                    case "4":
                        ShowOverdue(service);
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        static void ShowUsers()
        {
            Console.WriteLine("\nUsers:");
            foreach (var user in DataStore.Users)
            {
                Console.WriteLine($"{user.Id}: {user.FirstName} {user.LastName} (Max: {user.MaxRentals})");
            }
        }

        static void ShowEquipment()
        {
            Console.WriteLine("\nEquipment:");
            foreach (var eq in DataStore.Equipment)
            {
                Console.WriteLine($"{eq.Id}: {eq.Name} {eq.GetType().Name} - {(eq.IsAvailable ? "Available" : "Rented")}");
            }
        }

        static void RentEquipment(RentalService service)
        {
            try
            {
                Console.Write("Enter User ID: ");
                int userId = int.Parse(Console.ReadLine());

                Console.Write("Enter Equipment ID: ");
                int eqId = int.Parse(Console.ReadLine());

                Console.Write("Enter days: ");
                int days = int.Parse(Console.ReadLine());

                var user = DataStore.Users.FirstOrDefault(u => u.Id == userId);
                var equipment = DataStore.Equipment.FirstOrDefault(e => e.Id == eqId);

                if (user == null || equipment == null)
                {
                    Console.WriteLine("Invalid user or equipment.");
                    return;
                }

                service.RentEquipment(user, equipment, days);
                Console.WriteLine("Equipment rented successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void ShowOverdue(RentalService service)
        {
            Console.WriteLine("\nOverdue Rentals:");

            var overdue = service.GetOverdueRentals();

            if (!overdue.Any())
            {
                Console.WriteLine("None.");
                return;
            }

            foreach (var r in overdue)
            {
                Console.WriteLine($"{r.User.FirstName} {r.User.LastName} -> {r.Equipment.Name}");
            }
        }
}