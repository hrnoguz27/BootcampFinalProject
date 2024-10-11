using BootcampFinalProject.Models;
using BootcampFinalProject.Services;
using Microsoft.EntityFrameworkCore;

namespace BootcampFinalProject.Data;

public class MovieRepository : IMovieRepository
{
    private readonly AppDbContext _context;
    private readonly IFileService _fileService;

    public MovieRepository(AppDbContext context, IFileService fileService)
    {
        _context = context;
        _fileService = fileService;
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

    public async Task<Movie> AddMovieAsync(MovieDto movieDto)
    {
        string[] allowedExtensions = { "jpg", "jpeg", "png" };
        try
        {
            var movie = new Movie()
            {
                Title = movieDto.Title,
                Director = movieDto.Director,
                Genre = movieDto.Genre,
                ReleaseYear = movieDto.ReleaseYear,
                Rating = movieDto.Rating,
                RunningTimeInMin = movieDto.RunningTimeInMin,
                ThumbnailUrl = await _fileService.SaveFileAsync(movieDto.Thumbnail, allowedExtensions),
                BannerUrl = await _fileService.SaveFileAsync(movieDto.Banner, allowedExtensions, 3)
            };
            var createdMovie = await _context.Movies.AddAsync(movie);
            await _context.SaveChangesAsync();
            return createdMovie.Entity;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public async Task UpdateMovieAsync(MovieDto movieDto)
    {
        string[] allowedExtensions = { "jpg", "jpeg", "png" };
        try
        {
            var movie = new Movie()
            {
                Id = movieDto.Id,
                Title = movieDto.Title,
                Director = movieDto.Director,
                Genre = movieDto.Genre,
                ReleaseYear = movieDto.ReleaseYear,
                Rating = movieDto.Rating,
                RunningTimeInMin = movieDto.RunningTimeInMin,
                ThumbnailUrl = movieDto.ThumbnailUrl,
                BannerUrl = movieDto.BannerUrl
            };
            if (movieDto.Thumbnail != null)
            {
                var oldThumbnailPath = Path.Combine(Directory.GetCurrentDirectory(),"Uploads", movieDto.ThumbnailUrl.TrimStart('/'));
                if (File.Exists(oldThumbnailPath))
                {
                    File.Delete(oldThumbnailPath); // delete old thumbnail
                }                
                movie.ThumbnailUrl = await _fileService.SaveFileAsync(movieDto.Thumbnail, allowedExtensions);
            }
            if (movieDto.Banner != null)
            {
                var oldBannerPath = Path.Combine(Directory.GetCurrentDirectory(), movieDto.BannerUrl.TrimStart('/'));
                if (File.Exists(oldBannerPath))
                {
                    File.Delete(oldBannerPath); // delete old banner
                }
                movie.BannerUrl = await _fileService.SaveFileAsync(movieDto.Banner, allowedExtensions, 3);
            }

            _context.Entry(movie).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

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
