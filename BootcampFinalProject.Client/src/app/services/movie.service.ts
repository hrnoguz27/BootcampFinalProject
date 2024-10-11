import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Observable, Subject } from 'rxjs';
import { Router } from '@angular/router';
import { environment } from '../../environments/environment';
import { ToastrService } from 'ngx-toastr';

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
  private apiUrl = `${environment.apiUrl}/movies`;
  movies = new Subject<Movie[]>();
  constructor(private http: HttpClient, private router: Router,private toastr: ToastrService) { }

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

  addMovie(movie: FormData): void {
    this.http.post<Movie>(this.apiUrl, movie).subscribe(response => {
      this.toastr.success('Movie added successfully!', 'Create');
      this.router.navigateByUrl('dashboard')
    }, error => {
      console.log(error);
      
      this.toastr.error(error?.error, 'Create');
    });
  }

  updateMovie(id: number, movie: FormData): void {
    this.http.put<Movie>(`${this.apiUrl}/${id}`, movie).subscribe(response => {
      this.toastr.success('Movie updated successfully!', 'Update');      
      this.router.navigateByUrl('dashboard')
    }, error => {
      this.toastr.error(error?.error, 'Update');
    });
  }

  deleteMovie(id: number) {
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }
}