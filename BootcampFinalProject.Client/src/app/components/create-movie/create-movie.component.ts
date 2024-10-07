import { Component } from '@angular/core';
import { Movie, MovieService } from '../../services/movie.service';

@Component({
  selector: 'app-create-movie',
  templateUrl: './create-movie.component.html',
  styleUrl: './create-movie.component.scss'
})
export class CreateMovieComponent {
  newMovie: Movie = { title: '', genre: '', releaseYear: 0, director: '', rating: 0, imageURI: '' };
  selectedFile: File | null = null;

  constructor(private movieService: MovieService) {}

  // onFileSelected(event: any): void {
  //   this.selectedFile = event.target.files[0];
  // }

  addMovie(): void {
    if (this.newMovie.title) {
      this.movieService.addMovie(this.newMovie).subscribe(movie => {
        // if (this.selectedFile) {
        //   this.movieService.uploadPoster(movie.id!, this.selectedFile).subscribe();
        // }
      });
    }
  }
}