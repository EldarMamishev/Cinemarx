import * as tslib_1 from "tslib";
import { Component } from '@angular/core';
import { Validators } from "@angular/forms";
import { CreateCinemaEntityClass } from "./create-cinema-entity-class";
let CinemasAdminComponent = class CinemasAdminComponent {
    constructor(formBuilder, cinemaService) {
        this.formBuilder = formBuilder;
        this.cinemaService = cinemaService;
        this.selectedCinema = -1;
        this.newCinema = new CreateCinemaEntityClass();
    }
    ngOnInit() {
        this.cinemaAddForm = this.formBuilder.group({
            caption: [null, [Validators.required, Validators.minLength(4)]],
            address: ['', [Validators.required, Validators.minLength(4)]],
            description: [null]
        });
        this.cinemaChangeForm = this.formBuilder.group({
            caption: [null, [Validators.required, Validators.minLength(4)]],
            address: [null, [Validators.required, Validators.minLength(4)]],
            description: [null]
        });
        this.getCinemasFromDB();
    }
    onFormSubmit(data) {
    }
    createCinema() {
        this.newCinema.Caption = this.cinemaAddForm.get('caption').value;
        this.newCinema.Address = this.cinemaAddForm.get('address').value;
        this.newCinema.Description = this.cinemaAddForm.get('description').value;
        console.log('CinemaCaption: ' + this.newCinema.Caption + '\nCinemaAddress: ' + this.newCinema.Address);
        let temp;
        temp = this.cinemaService.addCinema(this.newCinema)
            .subscribe(res => {
            console.log(res);
        }, (err) => {
            console.log(err);
        });
        if (temp != null) {
            this.clearAddCinemaFields();
            this.getCinemasFromDB();
        }
    }
    clearAddCinemaFields() {
        const name = document.getElementById('cinemaCaption');
        const address = document.getElementById('cinemaAddress');
        const description = document.getElementById('cinemaDescription');
        name.value = '';
        address.value = '';
        description.value = '';
    }
    updateCinema() {
        let cinema = new CreateCinemaEntityClass();
        cinema.Caption = this.cinemaAddForm.get('caption').value;
        cinema.Address = this.cinemaAddForm.get('address').value;
        cinema.Description = this.cinemaAddForm.get('description').value;
        console.log('CinemaCaption: ' + this.newCinema.Caption + '\nCinemaAddress: ' + this.newCinema.Address);
        let temp;
        temp = this.cinemaService.updateCinema(cinema)
            .subscribe(res => {
            console.log(res);
        }, (err) => {
            console.log(err);
        });
        if (temp != null) {
            this.clearChangeCinemaFields();
            this.getCinemasFromDB();
        }
    }
    clearChangeCinemaFields() {
        const name = document.getElementById('cinemaChangeCaption');
        const address = document.getElementById('cinemaChangeAddress');
        const description = document.getElementById('cinemaChangeDescription');
        name.value = '';
        address.value = '';
        description;
    }
    selectCertainCinema(name) {
        let div;
        let text;
        for (let i = 0; i < this.cinemas.length; i++) {
            div = document.getElementsByClassName('cinemaNameAndAddress')[i];
            text = document.getElementsByClassName('cinemaText')[i];
            if (this.cinemas[i].caption === name) {
                this.selectedCinema = i;
                div.style.backgroundColor = 'black';
                div.style.border = 'solid white 1px';
                text.style.color = 'white';
                continue;
            }
            div.style.backgroundColor = 'white';
            div.style.border = 'solid black 1px';
            text.style.color = 'black';
        }
    }
    getCinemasFromDB() {
        this.cinemaService.getCinemas().subscribe(families => this.cinemas = families);
        ;
    }
};
CinemasAdminComponent = tslib_1.__decorate([
    Component({
        selector: 'app-cinemas-admin',
        templateUrl: './cinemas-admin.component.html',
        styleUrls: ['./cinemas-admin.component.css']
    })
], CinemasAdminComponent);
export { CinemasAdminComponent };
//# sourceMappingURL=cinemas-admin.component.js.map