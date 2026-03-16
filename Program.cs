class Program
{
    static void Main()
    {
        Student student1 = new Student(1, "Roman", "Klimovich");
        Employee employee1 = new Employee(2, "Anna", "Nowak");

        Console.WriteLine($"Student: {student1.firstName} {student1.lastName}, Max Rentals: {student1.MaxRentals}");
        Console.WriteLine($"Employee: {employee1.firstName} {employee1.lastName}, Max Rentals: {employee1.MaxRentals}");
    }
}
