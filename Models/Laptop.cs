public class Laptop : Equipment
{
    public string Cpu { get; set; }
    public int Ram { get; set; }

    public Laptop(int id, string name, string cpu, int ram)
        : base(id, name)
    {
        Cpu = cpu;
        Ram = ram;
    }
}