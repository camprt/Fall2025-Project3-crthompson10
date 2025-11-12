namespace Fall2025_Project3_crthompson10.Models;

public class Actor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }
    public string ImdbPage {get; set;}
    public byte[]? Photo { get; set; }
}