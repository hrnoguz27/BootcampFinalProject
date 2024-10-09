import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Movie, MovieService } from '../../services/movie.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-edit-movie',
  templateUrl: './edit-movie.component.html',
  styleUrl: './edit-movie.component.scss'
})
export class EditMovieComponent implements OnInit {
  movieForm!: FormGroup;
  submitted: boolean = false;
  currentMovie!: Movie;
  constructor(private route: ActivatedRoute, private fb: FormBuilder, private movieService: MovieService) { }
  ngOnInit() {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.movieService.getMovie(id).subscribe(movie => {
      this.currentMovie = movie
      this.updateMovieForm(this.currentMovie);
    });
  }

  updateMovieForm(formData: Movie) {
    this.movieForm = this.fb.group({
      id: [formData.id, Validators.required],
      title: [formData.title, Validators.required],
      director: [formData.director, Validators.compose([Validators.required])],
      releaseYear: [formData.releaseYear, Validators.compose([Validators.required, Validators.max((new Date()).getFullYear()), Validators.min(1800)])],
      genre: [formData.genre, Validators.required],
      thumbnailUrl: [formData.thumbnailUrl, Validators.compose([Validators.required])],
      bannerUrl: [formData.bannerUrl, Validators.compose([Validators.required])],
      rating: [formData.rating, Validators.compose([Validators.max(10), Validators.min(0.1)])],
      runningTimeInMin: [formData.runningTimeInMin, Validators.compose([Validators.required, Validators.min(1)])],
    });
  }

  get controls() { return this.movieForm.controls }

  isInvalid(controlName: string) {
    return (this.submitted && this.controls[controlName].errors) || (this.controls[controlName].touched && this.controls[controlName].errors);
  }

  updateMovie(): void {
    this.submitted = true;
    if (!this.movieForm.valid) return;
    this.movieService.updateMovie(this.controls['id'].value!, this.movieForm.value);
  }
}