public class Student : User
{
    public override int MaxRentals => 2;

    public Student(int id, string firstName, string lastName) 
        :base(id, firstName, lastName) { }    
}