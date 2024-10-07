import { Component, OnInit } from '@angular/core';
import { Movie, MovieService } from '../../services/movie.service';

@Component({
  selector: 'app-movie',
  templateUrl: './movie.component.html',
  styleUrls: ['./movie.component.scss']
})
export class MovieComponent implements OnInit {
  movies: Movie[] = [];
  newMovie: Movie = { title: '', genre: '', releaseYear: 0, director: '', rating: 0, imageURI: '' };

  constructor(private movieService: MovieService) {}

  ngOnInit(): void {
    this.loadMovies();
  }

  loadMovies(): void {
    this.movieService.getMovies().subscribe(data => {
      this.movies = data;
    });
  }

  addMovie(): void {
    if (this.newMovie.title) {
      this.movieService.addMovie(this.newMovie).subscribe(() => {
        this.loadMovies();
        this.newMovie = { title: '', genre: '', releaseYear: 0, director: '', rating: 0, imageURI: '' };
      });
    }
  }

  deleteMovie(id: number): void {
    this.movieService.deleteMovie(id).subscribe(() => {
      this.loadMovies();
    });
  }
}