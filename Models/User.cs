public abstract class User
{
    public int Id { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public abstract int MaxRentals { get; }

    public User(int id, string firstName, string lastName)
    {
        Id = id;
        this.firstName = firstName;
        this.lastName = lastName;
    }
}