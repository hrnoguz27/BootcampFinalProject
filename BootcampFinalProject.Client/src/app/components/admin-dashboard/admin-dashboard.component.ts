import { Component, OnInit } from '@angular/core';
import { Movie, MovieService } from '../../services/movie.service';

@Component({
  selector: 'app-admin-dashboard',
  templateUrl: './admin-dashboard.component.html',
  styleUrl: './admin-dashboard.component.scss'
})
export class AdminDashboardComponent implements OnInit {
  movies: Movie[] = [];
  constructor(private movieService: MovieService) { }
  ngOnInit(): void {
    this.loadMovies();
  }

  loadMovies(): void {
    this.movieService.getMovies();
    this.movieService.movies.subscribe(data=>{
      this.movies = data;
    })
  }
  
  deleteMovie(id: number): void {
    this.movieService.deleteMovie(id).subscribe(() => {
      this.loadMovies();
    });
  }
}
