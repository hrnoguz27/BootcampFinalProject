import { Component, OnInit } from '@angular/core';
import { MovieService } from '../../services/movie.service';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-create-movie',
  templateUrl: './create-movie.component.html',
  styleUrl: './create-movie.component.scss'
})
export class CreateMovieComponent implements OnInit {
  movieForm!: FormGroup;
  selectedThumbnail: File | null = null;
  selectedBanner: File | null = null;
  submitted: boolean = false;
  constructor(private movieService: MovieService, private toastr: ToastrService) { }
  ngOnInit() {
    this.movieForm = new FormGroup({
      title: new FormControl('', [Validators.required]),
      genre: new FormControl('', [Validators.required]),
      releaseYear: new FormControl('', [Validators.required, Validators.min(1800), Validators.max(new Date().getFullYear())]),
      director: new FormControl('', Validators.required),
      rating: new FormControl('', [Validators.required, Validators.min(0.1), Validators.max(10)]),
      runningTimeInMin: new FormControl('', [Validators.required, Validators.min(1)]),
      thumbnail: new FormControl(null, Validators.required),
      banner: new FormControl(null, Validators.required)
    });
  }

  onThumbnailSelected(event: any): void {
    this.selectedThumbnail = event.target.files[0];
    this.movieForm.patchValue({ thumbnail: this.selectedThumbnail });
  }

  onBannerSelected(event: any): void {
    this.selectedBanner = event.target.files[0];
    this.movieForm.patchValue({ banner: this.selectedBanner });
  }

  get controls() { return this.movieForm.controls }

  isInvalid(controlName: string) {
    return (this.submitted && this.controls[controlName].errors) || (this.controls[controlName].touched && this.controls[controlName].errors);
  }

  addMovie(): void {
    this.submitted = true;
    if (!this.selectedThumbnail) this.toastr.error('Thumbnail is required', 'Image Upload');
    if (!this.selectedBanner) this.toastr.error('Banner is required', 'Image Upload');
    if (this.movieForm.invalid || !this.selectedThumbnail || !this.selectedBanner) return;
    const movieData = this.movieForm.value;
    const formData = new FormData();
    formData.append('Title', movieData.title);
    formData.append('Director', movieData.director);
    formData.append('ReleaseYear', movieData.releaseYear);
    formData.append('Genre', movieData.genre);
    formData.append('Rating', movieData.rating);
    formData.append('RunningTimeInMin', movieData.runningTimeInMin);
    formData.append('Thumbnail', this.selectedThumbnail!);
    formData.append('Banner', this.selectedBanner!);
    this.movieService.addMovie(formData);
  }
}