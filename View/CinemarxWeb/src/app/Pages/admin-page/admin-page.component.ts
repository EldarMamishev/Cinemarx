import { Component, OnInit } from '@angular/core';
import {Router} from "@angular/router";

@Component({
  selector: 'app-admin-page',
  templateUrl: './admin-page.component.html',
  styleUrls: ['./admin-page.component.css']
})
export class AdminPageComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit() {
  }

  showCertainContent(name) {

    const mainAdminPageTab: any = document.getElementById('mainAdminPageTab');
    const cinemaTab: any = document.getElementById('cinemaTab');
    const filmTab: any = document.getElementById('filmTab');

    const defaul: any = document.getElementsByClassName('DefaultMain')[0];
    const cinema: any = document.getElementsByClassName('cinema')[0];
    // const film: any = document.getElementsByClassName('film')[0];

    if (name === 'cinema') {

      mainAdminPageTab.style.fontWeight = 'normal';
      filmTab.style.fontWeight = 'normal';
      cinemaTab.style.fontWeight = 'bold';

      defaul.style.display = 'none';
      cinema.style.display = 'flex';

    } else if (name == 'film') {

      mainAdminPageTab.style.fontWeight = 'normal';
      filmTab.style.fontWeight = 'bold';
      cinemaTab.style.fontWeight = 'normal';

      defaul.style.display = 'none';
      cinema.style.display = 'none';
    } else {

      mainAdminPageTab.style.fontWeight = 'bold';
      filmTab.style.fontWeight = 'normal';
      cinemaTab.style.fontWeight = 'normal';

      cinema.style.display = 'none';

      defaul.style.display = 'flex';
    }
  }

}
