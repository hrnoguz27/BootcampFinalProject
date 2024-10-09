import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MovieComponent } from './components/movie/movie.component';
import { CreateMovieComponent } from './components/create-movie/create-movie.component';
import { EditMovieComponent } from './components/edit-movie/edit-movie.component';
import { AdminDashboardComponent } from './components/admin-dashboard/admin-dashboard.component';
import { MovieDetailComponent } from './components/movie-detail/movie-detail.component';

const routes: Routes = [
  { path: '', component: MovieComponent },
  { path: 'detail/:id', component: MovieDetailComponent },
  { path: 'dashboard', component:AdminDashboardComponent},
  { path: 'dashboard/create', component: CreateMovieComponent },
  { path: 'dashboard/edit/:id', component: EditMovieComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
