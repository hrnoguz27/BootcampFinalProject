namespace BootcampFinalProject.Models;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
    public int ReleaseYear { get; set; }
    public string Director { get; set; }
    public decimal Rating { get; set; }
    public string ThumbnailUrl { get; set; }
    public string BannerUrl { get; set; }
    public int RunningTimeInMin { get; set; }
}
