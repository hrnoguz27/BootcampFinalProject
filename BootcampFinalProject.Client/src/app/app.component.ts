import { Component } from '@angular/core';
import { MovieService } from './services/movie.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'HO Movie';
  constructor(private movieService: MovieService) { }
  onSubmit(search: any) {

    this.movieService.getMovies(search);
  }
}
