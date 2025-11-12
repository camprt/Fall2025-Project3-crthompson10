using Fall2025_Project3_crthompson10.Models.ViewModels;
using Microsoft.Win32;

namespace Fall2025_Project3_crthompson10.Models.ViewModels;

public class MovieDetailsViewModel
{
    public Movie Movie { get; set; }
    public IEnumerable<Actor> Actors { get; set; }
    public IEnumerable<string> Reviews { get; set; }
    public IEnumerable<double> ReviewSentiments { get; set; }
    public double AverageSentiment { get; set; }
}