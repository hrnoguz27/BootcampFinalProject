﻿using BootcampFinalProject.Models;

namespace BootcampFinalProject.Data;

public interface IMovieRepository
{
    Task<IEnumerable<Movie>> GetAllMoviesAsync(string searchQuery);
    Task<Movie> GetMovieByIdAsync(int id);
    Task AddMovieAsync(Movie movie);
    Task UpdateMovieAsync(Movie movie);
    Task DeleteMovieAsync(int id);
    Task<bool> MovieExistsAsync(int id);
}
