import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Movie, MovieService } from '../../services/movie.service';

@Component({
  selector: 'app-edit-movie',
  templateUrl: './edit-movie.component.html',
  styleUrl: './edit-movie.component.scss'
})
export class EditMovieComponent {
  selectedMovie: Movie = { title: '', genre: '', releaseYear: 0, director: '', rating: 0, imageURI: '' };
  selectedFile: File | null = null;

  constructor(private route: ActivatedRoute, private movieService: MovieService) {}

  ngOnInit(): void {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.movieService.getMovie(id).subscribe(movie => this.selectedMovie = movie);
  }

  // onFileSelected(event: any): void {
  //   this.selectedFile = event.target.files[0];
  // }

  updateMovie(): void {
    if (this.selectedMovie.title) {
      this.movieService.updateMovie(this.selectedMovie.id!, this.selectedMovie).subscribe(() => {
        // if (this.selectedFile) {
        //   this.movieService.uploadPoster(this.selectedMovie.id!, this.selectedFile).subscribe();
        // }
      });
    }
  }
}