import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Movie, MovieService } from '../../services/movie.service';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { environment } from '../../../environments/environment';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-edit-movie',
  templateUrl: './edit-movie.component.html',
  styleUrl: './edit-movie.component.scss'
})
export class EditMovieComponent implements OnInit {
  movieForm!: FormGroup;
  submitted: boolean = false;
  currentMovie!: Movie;
  resourceUrl:string = environment.resourceUrl;
  selectedThumbnail: File | null = null;
  selectedBanner: File | null = null;
  constructor(private route: ActivatedRoute, private fb: FormBuilder, private movieService: MovieService, private toastr: ToastrService) { }
  ngOnInit() {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.movieService.getMovie(id).subscribe(movie => {
      this.currentMovie = movie;
      console.log(movie);
      
      this.movieForm = new FormGroup({
        id:new FormControl(movie.id, Validators.required),
        title: new FormControl(movie.title, [Validators.required]),
        genre: new FormControl(movie.genre, [Validators.required]),
        releaseYear: new FormControl(movie.releaseYear, [Validators.required, Validators.min(1800), Validators.max(new Date().getFullYear())]),
        director: new FormControl(movie.director, Validators.required),
        rating: new FormControl(movie.rating, [Validators.required, Validators.min(0.1), Validators.max(10)]),
        runningTimeInMin: new FormControl(movie.runningTimeInMin, [Validators.required, Validators.min(1)]),
        thumbnailUrl: new FormControl(movie.thumbnailUrl, Validators.required),
        bannerUrl: new FormControl(movie.bannerUrl, Validators.required),
        thumbnail: new FormControl(null),
        banner: new FormControl(null)
      });
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

  updateMovie(): void {
    this.submitted = true;
    if (this.movieForm.invalid) return;
    const movieData = this.movieForm.value;
    const formData = new FormData();
    formData.append('Id', movieData.id);
    formData.append('Title', movieData.title);
    formData.append('Director', movieData.director);
    formData.append('ReleaseYear', movieData.releaseYear);
    formData.append('Genre', movieData.genre);
    formData.append('Rating', movieData.rating);
    formData.append('RunningTimeInMin', movieData.runningTimeInMin);
    formData.append('ThumbnailUrl', movieData.thumbnailUrl);
    formData.append('BannerUrl', movieData.bannerUrl);
    formData.append('Thumbnail', this.selectedThumbnail!);
    formData.append('Banner', this.selectedBanner!);
    this.movieService.updateMovie(this.controls['id'].value!, formData);
  }
}