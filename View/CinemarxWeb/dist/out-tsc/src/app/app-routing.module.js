import * as tslib_1 from "tslib";
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { MainPageComponent } from './Pages/main-page/main-page.component';
import { AdminPageComponent } from "./Pages/admin-page/admin-page.component";
const routes = [
    {
        path: '',
        redirectTo: 'admin',
        pathMatch: 'full',
    },
    {
        path: 'mainPage',
        component: MainPageComponent,
        data: { title: 'CinemarX' }
    },
    {
        path: 'admin',
        component: AdminPageComponent,
        data: { title: 'ADMIN-PANEL' }
    },
];
let AppRoutingModule = class AppRoutingModule {
};
AppRoutingModule = tslib_1.__decorate([
    NgModule({
        imports: [RouterModule.forRoot(routes)],
        exports: [RouterModule]
    })
], AppRoutingModule);
export { AppRoutingModule };
//# sourceMappingURL=app-routing.module.js.map