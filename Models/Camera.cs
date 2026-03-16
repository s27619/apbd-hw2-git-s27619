public class Camera : Equipment
{
    public int megapixels { get; set; }
    public string lens { get; set; }
    public bool isDSLR { get; set; }

    public Camera(int id, string name, int megapixels, string lens, bool isDSLR)
        : base(id, name)
    {
        this.megapixels = megapixels;
        this.lens = lens;
        this.isDSLR = isDSLR;  
    }
}