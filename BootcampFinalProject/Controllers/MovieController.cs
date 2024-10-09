using BootcampFinalProject.Data;
using BootcampFinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace BootcampFinalProject.Controllers;
[Route("api/[controller]")]
[ApiController]
public class MoviesController : ControllerBase
{
    private readonly IMovieRepository _movieRepository;

    public MoviesController(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Movie>>> GetMovies(string search)
    {
        var movies = await _movieRepository.GetAllMoviesAsync(search);
        return Ok(movies);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Movie>> GetMovie(int id)
    {
        var movie = await _movieRepository.GetMovieByIdAsync(id);

        if (movie == null)
        {
            return NotFound();
        }

        return Ok(movie);
    }

    [HttpPost]
    public async Task<ActionResult<Movie>> PostMovie(Movie movie)
    {
        await _movieRepository.AddMovieAsync(movie);
        return CreatedAtAction(nameof(GetMovie), new { id = movie.Id }, movie);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutMovie(int id, Movie movie)
    {
        if (id != movie.Id)
        {
            return BadRequest();
        }

        var exists = await _movieRepository.MovieExistsAsync(id);
        if (!exists)
        {
            return NotFound();
        }

        await _movieRepository.UpdateMovieAsync(movie);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMovie(int id)
    {
        var exists = await _movieRepository.MovieExistsAsync(id);
        if (!exists)
        {
            return NotFound();
        }

        await _movieRepository.DeleteMovieAsync(id);
        return NoContent();
    }
}
