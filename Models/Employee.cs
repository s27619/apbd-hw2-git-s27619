public class Employee : User
{
    public override int MaxRentals => 5;

    public Employee(int id, string firstName, string lastName)
        : base(id, firstName, lastName) { }
}