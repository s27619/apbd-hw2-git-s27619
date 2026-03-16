using System.Security.Cryptography.X509Certificates;
using System.Text;

public abstract class Equipment
{
    public int Id { get; set; }
    public string Name {get; set; }
    public bool isAvailable { get; set; }

    public Equipment(int id, string name)
    {
        Id = id;
        Name = name;
        isAvailable = true;
    }
}