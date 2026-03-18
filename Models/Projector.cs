public class Projector : Equipment
{
    public int Lumens { get; set; }
    public bool IsPortable { get; set; }

    public Projector(int id, string name, int lumens, bool isPortable)
        : base(id, name)
    {
        Lumens = lumens;
        IsPortable = isPortable;
    }
}