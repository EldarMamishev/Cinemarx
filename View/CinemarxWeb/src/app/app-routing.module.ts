import {NgModule} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';
import {MainPageComponent} from './Pages/main-page/main-page.component';


const routes: Routes = [
  {
    path: '',
    redirectTo: 'mainPage',
    pathMatch: 'full',
  },
  {
    path: 'mainPage',
    component: MainPageComponent,
    data: {title: 'CinemarX'}
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {
}
