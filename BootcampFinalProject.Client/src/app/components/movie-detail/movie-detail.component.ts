import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Movie, MovieService } from '../../services/movie.service';
import { environment } from '../../../environments/environment';

@Component({
  selector: 'app-movie-detail',
  templateUrl: './movie-detail.component.html',
  styleUrl: './movie-detail.component.scss'
})
export class MovieDetailComponent implements OnInit{
  currentMovie!: Movie;
  resourceUrl:string = environment.resourceUrl;
  constructor(private route: ActivatedRoute, private movieService: MovieService) { }

  ngOnInit() {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.movieService.getMovie(id).subscribe(movie => {
      this.currentMovie = movie
    });
  }
  get genres() { return this.currentMovie.genre.split(',')}
  get runningTime() { 
    var hours = Math.floor(this.currentMovie.runningTimeInMin / 60);          
    var minutes = this.currentMovie.runningTimeInMin % 60;
    return `${hours}h ${minutes}m`
  }
}
