import { Component, OnInit } from '@angular/core';
import { MovieService } from '../../services/movie.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-create-movie',
  templateUrl: './create-movie.component.html',
  styleUrl: './create-movie.component.scss'
})
export class CreateMovieComponent implements OnInit {
  newMovieForm!: FormGroup;
  submitted: boolean = false;
  constructor(private fb: FormBuilder, private movieService: MovieService) { }
  ngOnInit() {
    this.createMovieForm();
  }

  createMovieForm() {
    this.newMovieForm = this.fb.group({
      title: ['', Validators.required],
      director: ['', Validators.compose([Validators.required])],
      releaseYear: ['', Validators.compose([Validators.required, Validators.max((new Date()).getFullYear()), Validators.min(1800)])],
      genre: ['', Validators.required],
      thumbnailUrl: ['', Validators.compose([Validators.required])],
      bannerUrl: ['', Validators.compose([Validators.required])],
      rating: ['', Validators.compose([Validators.max(10), Validators.min(0.1)])],
      runningTimeInMin: [null, Validators.compose([Validators.required, Validators.min(1)])],
    });
  }
  
  get controls() { return this.newMovieForm.controls }

  isInvalid(controlName: string) {
    return (this.submitted && this.controls[controlName].errors) || (this.controls[controlName].touched && this.controls[controlName].errors);
  }

  addMovie(): void {
    this.submitted = true;
    if (!this.newMovieForm.valid) return;
    this.movieService.addMovie(this.newMovieForm.value);
  }
}