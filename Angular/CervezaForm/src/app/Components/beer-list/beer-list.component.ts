import { Component, OnInit } from '@angular/core';
import { Beer } from 'src/app/shared/interfaces/beer';

@Component({
  selector: 'app-beer-list',
  templateUrl: './beer-list.component.html',
  styleUrls: ['./beer-list.component.css']
})
export class BeerListComponent implements OnInit {
  beerList:Beer[] = [
    {
    name: 'Light', alcohol: 3,
    description: 'Se pasan de lanza', brand: 'Tecate'
    },
    {
      name: 'Rep Cristalino', alcohol: 34,
      description: 'Blanco', brand: 'Cuervo Tradicional'
    }
  ]
  constructor() { }

  ngOnInit() {
  }

}
