import { Component, OnInit } from '@angular/core';
import { Movie, MovieService } from '../../services/movie.service';

@Component({
  selector: 'app-movie',
  templateUrl: './movie.component.html',
  styleUrls: ['./movie.component.scss']
})
export class MovieComponent implements OnInit {
  movies: Movie[] = [];
  newMovie: Movie = { title: '', genre: '', releaseYear: 0, director: '', rating: 0, thumbnailUrl: '',  bannerUrl: '', runningTimeInMin: 0 };

  constructor(private movieService: MovieService) {}

  ngOnInit(): void {
    this.loadMovies();
  }

  loadMovies(): void {
    this.movieService.getMovies();
    this.movieService.movies.subscribe(data=>{
      this.movies = data;
    })
  }
}