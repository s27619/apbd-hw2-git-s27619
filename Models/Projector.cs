public class Projector : Equipment
{
    public int lumens { get; set; }
    public bool isPortable { get; set; }

    public Projector(int id, string name, int lumens, bool isPortable)
        : base(id, name)
    {
        this.lumens = lumens;
        this.isPortable = isPortable;
    }
}