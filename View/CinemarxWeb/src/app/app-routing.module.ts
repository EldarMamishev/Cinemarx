import {NgModule} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';
import {MainPageComponent} from './Pages/main-page/main-page.component';
import {AdminPageComponent} from "./Pages/admin-page/admin-page.component";


const routes: Routes = [
  {
    path: '',
    redirectTo: 'admin',
    pathMatch: 'full',
  },
  {
    path: 'mainPage',
    component: MainPageComponent,
    data: {title: 'CinemarX'}
  },
  {
    path: 'admin',
    component: AdminPageComponent,
    data: {title: 'ADMIN-PANEL'}
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {
}
