import * as tslib_1 from "tslib";
import { Component } from '@angular/core';
let AdminPageComponent = class AdminPageComponent {
    constructor(router) {
        this.router = router;
    }
    ngOnInit() {
    }
    showCertainContent(name) {
        const mainAdminPageTab = document.getElementById('mainAdminPageTab');
        const cinemaTab = document.getElementById('cinemaTab');
        const filmTab = document.getElementById('filmTab');
        const defaul = document.getElementsByClassName('DefaultMain')[0];
        const cinema = document.getElementsByClassName('cinema')[0];
        // const film: any = document.getElementsByClassName('film')[0];
        if (name === 'cinema') {
            mainAdminPageTab.style.fontWeight = 'normal';
            filmTab.style.fontWeight = 'normal';
            cinemaTab.style.fontWeight = 'bold';
            defaul.style.display = 'none';
            cinema.style.display = 'flex';
        }
        else if (name == 'film') {
            mainAdminPageTab.style.fontWeight = 'normal';
            filmTab.style.fontWeight = 'bold';
            cinemaTab.style.fontWeight = 'normal';
            defaul.style.display = 'none';
            cinema.style.display = 'none';
        }
        else {
            mainAdminPageTab.style.fontWeight = 'bold';
            filmTab.style.fontWeight = 'normal';
            cinemaTab.style.fontWeight = 'normal';
            cinema.style.display = 'none';
            defaul.style.display = 'flex';
        }
    }
};
AdminPageComponent = tslib_1.__decorate([
    Component({
        selector: 'app-admin-page',
        templateUrl: './admin-page.component.html',
        styleUrls: ['./admin-page.component.css']
    })
], AdminPageComponent);
export { AdminPageComponent };
//# sourceMappingURL=admin-page.component.js.map