namespace Fall2025_Project3_crthompson10.Models;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int ReleaseYear { get; set; }
    public string ImdbLink { get; set; }
    public byte[]? Poster { get; set; }
}