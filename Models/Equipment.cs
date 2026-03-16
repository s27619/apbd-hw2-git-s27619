public abstract class Equipment
{
    public int Id { get; set; }
    public string Name {get; set; }
    public bool IsAvailable { get; set; }

    public Equipment(int id, string name)
    {
        Id = id;
        Name = name;
        IsAvailable = true;
    }
}