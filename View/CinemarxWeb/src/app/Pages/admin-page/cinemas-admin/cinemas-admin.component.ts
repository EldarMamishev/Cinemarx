import {Component, OnInit} from '@angular/core';
import {FormBuilder, FormGroup, NgForm, Validators} from "@angular/forms";
import {AdminCinemaControlService} from "../../../Services/admin-cinema-control.service";
import {CreateCinemaEntityClass} from "./create-cinema-entity-class";


@Component({
    selector: 'app-cinemas-admin',
    templateUrl: './cinemas-admin.component.html',
    styleUrls: ['./cinemas-admin.component.css']
})
export class CinemasAdminComponent implements OnInit {
    cinemas: currentCinemas[];
    selectedCinema = -1;
    cinemaAddForm: FormGroup;
    cinemaChangeForm: FormGroup;
    newCinema: CreateCinemaEntityClass = new CreateCinemaEntityClass();

    constructor(private formBuilder: FormBuilder, private createCinemaService: AdminCinemaControlService) {
        this.cinemas = [new currentCinemas('CinemarX', 'Napoleon street'),
            new currentCinemas('CinemarXXX', 'RedLight street')];
    }

    ngOnInit() {
        this.cinemaAddForm = this.formBuilder.group({
            name: [null, [Validators.required, Validators.minLength(4)]],
            address: [null, [Validators.required, Validators.minLength(4)]]
        });

        this.cinemaChangeForm = this.formBuilder.group({
            name: [null, [Validators.required, Validators.minLength(4)]],
            address: [null, [Validators.required, Validators.minLength(4)]]
        });
    }

    onFormSubmit(data: any) {

    }

    createCinema() {
        this.newCinema.Caption = this.cinemaAddForm.get('name').value;
        this.newCinema.Address = this.cinemaAddForm.get('address').value;

        console.log('CinemaName: ' + this.newCinema.Caption + '\nCinemaAddress: ' + this.newCinema.Address);

        this.createCinemaService.addCinema(this.newCinema)
            .subscribe(res => {
                console.log(res);
            }, (err) => {
                console.log(err);
            });
    }

    clearAddCinemaFields() {
        const name: any = document.getElementById('cinemaName');
        const address: any = document.getElementById('cinemaAddress');

        name.value = '';
        address.value = '';
    }

    clearChangeCinemaFields() {
        const name: any = document.getElementById('cinemaChangeName');
        const address: any = document.getElementById('cinemaChangeAddress');

        name.value = '';
        address.value = '';
    }

    selectCertainCinema(name) {
        let div: any;
        let text: any;
        for (let i = 0; i < this.cinemas.length; i++) {
            div = document.getElementsByClassName('cinemaNameAndAddress')[i];
            text = document.getElementsByClassName('cinemaText')[i];
            if (this.cinemas[i].name === name) {
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

}

export class currentCinemas {
    name: string;
    address: string;

    constructor(name, address) {
        this.name = name;
        this.address = address;
    }

}
