import {BrowserModule} from '@angular/platform-browser';
import {NgModule} from '@angular/core';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';

import {AppRoutingModule} from './app-routing.module';

import {AppComponent} from './app.component';
import {MainPageComponent} from './Pages/main-page/main-page.component';
import {AdminPageComponent} from './Pages/admin-page/admin-page.component';
import {CinemasAdminComponent} from './Pages/admin-page/cinemas-admin/cinemas-admin.component';
import {HttpClientModule, HttpClient} from '@angular/common/http';

@NgModule({
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
export class AppModule {
}
