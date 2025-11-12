namespace Fall2025_Project3_crthompson10.Models.ViewModels;

public class ActorDetailsViewModel
{
    public Actor Actor { get; set; }
    public IEnumerable<Movie> Movies { get; set; }
    public IEnumerable<string> Tweets { get; set; }
    public IEnumerable<double> TweetSentiments { get; set; }
    public double AverageTweetSentiment { get; set; }
}