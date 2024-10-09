using BootcampFinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace BootcampFinalProject.Data;

public class MovieRepository : IMovieRepository
{
    private readonly AppDbContext _context;

    public MovieRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Movie>> GetAllMoviesAsync(string searchQuery)
    {
        var result = !string.IsNullOrEmpty(searchQuery)
            ? await _context.Movies.Where(x => x.Title.ToLower().Contains(searchQuery) || x.Director.ToLower().Contains(searchQuery) || x.Genre.ToLower().Contains(searchQuery)).ToListAsync()
            : await _context.Movies.ToListAsync();

        return result;

    }

    public async Task<Movie> GetMovieByIdAsync(int id)
    {
        return await _context.Movies.FindAsync(id);
    }

    public async Task AddMovieAsync(Movie movie)
    {
        await _context.Movies.AddAsync(movie);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateMovieAsync(Movie movie)
    {
        _context.Entry(movie).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteMovieAsync(int id)
    {
        var movie = await _context.Movies.FindAsync(id);
        if (movie != null)
        {
            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<bool> MovieExistsAsync(int id)
    {
        return await _context.Movies.AnyAsync(e => e.Id == id);
    }
}
