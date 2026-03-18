public class Camera : Equipment
{
    public int Megapixels { get; set; }
    public string Lens { get; set; }
    public bool IsDSLR { get; set; }

    public Camera(int id, string name, int megapixels, string lens, bool isDSLR)
        : base(id, name)
    {
        Megapixels = megapixels;
        Lens = lens;
        IsDSLR = isDSLR;  
    }
}