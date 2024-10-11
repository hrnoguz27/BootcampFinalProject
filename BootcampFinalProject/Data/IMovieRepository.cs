using BootcampFinalProject.Models;

namespace BootcampFinalProject.Data;

public interface IMovieRepository
{
    Task<IEnumerable<Movie>> GetAllMoviesAsync(string searchQuery);
    Task<Movie> GetMovieByIdAsync(int id);
    Task<Movie> AddMovieAsync(MovieDto movie);
    Task UpdateMovieAsync(MovieDto movie);
    Task DeleteMovieAsync(int id);
    Task<bool> MovieExistsAsync(int id);
}
