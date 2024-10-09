import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Observable, Subject } from 'rxjs';
import { Router } from '@angular/router';

export interface Movie {
  id?: number;
  title: string;
  genre: string;
  releaseYear: number;
  director: string;
  rating: number;
  thumbnailUrl: string;
  bannerUrl: string;
  runningTimeInMin: number;
}

@Injectable({
  providedIn: 'root'
})
export class MovieService {
  private apiUrl = 'https://localhost:7278/api/movies';
  movies = new Subject<Movie[]>();
  constructor(private http: HttpClient, private router: Router) { }

  getMovies(searchText?: string) {
    let params: any;
    if (searchText) {
      params = new HttpParams().set("search", searchText!);
    }
    this.http.get<Movie[]>(this.apiUrl, { params: params }).subscribe(x => this.movies.next(x));
  }

  getMovie(id: number): Observable<Movie> {
    return this.http.get<Movie>(`${this.apiUrl}/${id}`);
  }

  addMovie(movie: Movie): void {
    this.http.post<Movie>(this.apiUrl, movie, {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      })
    }).subscribe(response => {
      console.log('Movie added successfully:', response);
      this.router.navigateByUrl('dashboard')
    }, error => {
      console.error('Error adding movie:', error);
    });
  }

  updateMovie(id: number, movie: Movie): void {
    this.http.put<Movie>(`${this.apiUrl}/${id}`, movie, {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      })
    }).subscribe(response => {
      console.log('Movie updated successfully:', response);
      this.router.navigateByUrl('dashboard')
    }, error => {
      console.error('Error updating movie:', error);
    });
  }

  deleteMovie(id: number) {
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }
}