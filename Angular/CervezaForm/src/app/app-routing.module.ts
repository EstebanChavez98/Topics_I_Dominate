import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BeerListComponent } from './Components/beer-list/beer-list.component';
import { PageNotFoundComponent } from './page/page-not-found/page-not-found.component';
import { AddBeerComponent } from './Components/add-beer/add-beer.component';


const routes: Routes = [
  { path: 'beer-list', component: BeerListComponent},
  { path: '', redirectTo: '/beer-list', pathMatch: 'full'},
  { path: '*', component: PageNotFoundComponent},
  { path: 'add-beer', component: AddBeerComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
