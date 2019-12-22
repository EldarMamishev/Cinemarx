import * as tslib_1 from "tslib";
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MainPageComponent } from './Pages/main-page/main-page.component';
import { AdminPageComponent } from './Pages/admin-page/admin-page.component';
import { CinemasAdminComponent } from './Pages/admin-page/cinemas-admin/cinemas-admin.component';
import { HttpClientModule } from '@angular/common/http';
let AppModule = class AppModule {
};
AppModule = tslib_1.__decorate([
    NgModule({
        declarations: [
            AppComponent,
            MainPageComponent,
            AdminPageComponent,
            CinemasAdminComponent,
        ],
        imports: [
            BrowserModule,
            AppRoutingModule,
            FormsModule,
            ReactiveFormsModule,
            HttpClientModule
        ],
        providers: [],
        bootstrap: [AppComponent]
    })
], AppModule);
export { AppModule };
//# sourceMappingURL=app.module.js.map