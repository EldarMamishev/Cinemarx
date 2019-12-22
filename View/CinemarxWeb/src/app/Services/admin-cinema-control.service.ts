import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable, of} from 'rxjs';
import {catchError, tap} from 'rxjs/operators';
import {CreateCinemaEntityClass} from "../Pages/admin-page/cinemas-admin/create-cinema-entity-class";
import { CinemaResponse } from '../Pages/admin-page/cinemas-admin/cinema-response';

const apiUrl = 'https://localhost:44328/api/';

@Injectable({
  providedIn: 'root'
})
export class AdminCinemaControlService {

  constructor(private http: HttpClient) { }

  addCinema(data: CreateCinemaEntityClass): Observable<CreateCinemaEntityClass> {
    return this.http.post<any>(apiUrl + 'cinema/create', data)
        .pipe(
            catchError(this.handleError('create', []))
        );
  }

  updateCinema(data: CinemaResponse): Observable<CinemaResponse> {
    return this.http.post<any>(apiUrl + 'cinema/update', data)
        .pipe(
            catchError(this.handleError('update', []))
        );
  }

  getCinemas(): Observable<CinemaResponse[]> {
    return this.http.get<any>(apiUrl + 'cinema')
        .pipe(
            catchError(this.handleError('', []))
        );
  }

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {

      console.error(error);
      this.log(`${operation} failed: ${error.message}`);

      return of(result as T);
    };
  }

  private log(message: string) {
    console.log(message);
  }
}
