import * as tslib_1 from "tslib";
import { Injectable } from '@angular/core';
import { of } from 'rxjs';
import { catchError } from 'rxjs/operators';
const apiUrl = 'https://localhost:44328/api/';
let AdminCinemaControlService = class AdminCinemaControlService {
    constructor(http) {
        this.http = http;
    }
    addCinema(data) {
        return this.http.post(apiUrl + 'cinema/create', data)
            .pipe(catchError(this.handleError('create', [])));
    }
    updateCinema(data) {
        return this.http.post(apiUrl + 'cinema/update', data)
            .pipe(catchError(this.handleError('update', [])));
    }
    getCinemas() {
        return this.http.get(apiUrl + 'cinema')
            .pipe(catchError(this.handleError('', [])));
    }
    handleError(operation = 'operation', result) {
        return (error) => {
            console.error(error);
            this.log(`${operation} failed: ${error.message}`);
            return of(result);
        };
    }
    log(message) {
        console.log(message);
    }
};
AdminCinemaControlService = tslib_1.__decorate([
    Injectable({
        providedIn: 'root'
    })
], AdminCinemaControlService);
export { AdminCinemaControlService };
//# sourceMappingURL=admin-cinema-control.service.js.map