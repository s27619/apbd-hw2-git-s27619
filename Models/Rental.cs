public class Rental
{
    public User user { get; set; }
    public Equipment equipment { get; set; }

    public DateTime rentalDate { get; set; }
    public DateTime dueDate { get; set; }
    public DateTime? returnDate { get; set; }

    public double penalty { get; set; }

    public bool IsReturned => returnDate != null;
}