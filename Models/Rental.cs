public class Rental
{
    public User User { get; set; } = null!;
    public Equipment Equipment { get; set; } = null!;

    public DateTime RentalDate  { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime? ReturnDate { get; set; }

    public double Penalty { get; set; }

    public bool IsReturned => ReturnDate != null;
}