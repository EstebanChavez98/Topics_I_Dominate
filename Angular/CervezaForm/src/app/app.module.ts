import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BeerListComponent } from './Components/beer-list/beer-list.component';
import { PageNotFoundComponent } from './page/page-not-found/page-not-found.component';
import { ReactiveFormsModule } from '@angular/forms'; 
import { AddBeerComponent } from './Components/add-beer/add-beer.component';

@NgModule({
  declarations: [
    AppComponent,
    BeerListComponent,
    PageNotFoundComponent,
    AddBeerComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
