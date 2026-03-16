public class Laptop : Equipment
{
    public string cpu { get; set; }
    public int ram { get; set; }

    public Laptop(int id, string name, string cpu, int ram)
        : base(id, name)
    {
        this.cpu = cpu;
        this.ram = ram;
    }
}