import {Component, OnInit} from '@angular/core';
import {FormBuilder, FormGroup, NgForm, Validators} from "@angular/forms";
import {AdminCinemaControlService} from "../../../Services/admin-cinema-control.service";
import {CreateCinemaEntityClass} from "./create-cinema-entity-class";
import { FilmResponse } from './film-response';


@Component({
    selector: 'app-cinemas-admin',
    templateUrl: './cinemas-admin.component.html',
    styleUrls: ['./cinemas-admin.component.css']
})
export class CinemasAdminComponent implements OnInit {
    cinemas: FilmResponse[];
    selectedCinema = -1;
    cinemaAddForm: FormGroup;
    cinemaChangeForm: FormGroup;
    newCinema: CreateCinemaEntityClass = new CreateCinemaEntityClass();

    constructor(private formBuilder: FormBuilder, private cinemaService: AdminCinemaControlService) {

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

    onFormSubmit(data: any) {

    }

    createCinema() {
        this.newCinema.Caption = this.cinemaAddForm.get('caption').value;
        this.newCinema.Address = this.cinemaAddForm.get('address').value;
        this.newCinema.Description = this.cinemaAddForm.get('description').value;

        console.log('CinemaCaption: ' + this.newCinema.Caption + '\nCinemaAddress: ' + this.newCinema.Address);
        let temp : any;
        temp = this.cinemaService.addCinema(this.newCinema)
            .subscribe(res => {
                console.log(res);
            }, (err) => {
                console.log(err);
            });

        if(temp != null)
        {
            this.clearAddCinemaFields();
            this.getCinemasFromDB();
        }
    }

    clearAddCinemaFields() {
        const name: any = document.getElementById('cinemaCaption');
        const address: any = document.getElementById('cinemaAddress');
        const description: any = document.getElementById('cinemaDescription');

        name.value = '';
        address.value = '';
        description.value = '';
    }

    updateCinema() {
        let cinema = this.cinemas[this.selectedCinema];
        cinema.caption = this.cinemaAddForm.get('caption').value;
        cinema.address = this.cinemaAddForm.get('address').value;
        cinema.description = this.cinemaAddForm.get('description').value;

        console.log('CinemaCaption: ' + this.newCinema.Caption + '\nCinemaAddress: ' + this.newCinema.Address);
        let temp = this.cinemaService.updateCinema(cinema)
            .subscribe(res => {
                console.log(res);
            }, (err) => {
                console.log(err);
            });

        if(temp != null)
        {
            this.clearChangeCinemaFields();
            this.getCinemasFromDB();
        }
    }

    clearChangeCinemaFields() {
        const name: any = document.getElementById('cinemaChangeCaption');
        const address: any = document.getElementById('cinemaChangeAddress');
        const description : any = document.getElementById('cinemaChangeDescription');

        name.value = '';
        address.value = '';
        description
    }

    selectCertainCinema(name) {
        let div: any;
        let text: any;
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

    getCinemasFromDB()
    {
        this.cinemaService.getCinemas().subscribe(families => this.cinemas = families);;
    }

}
