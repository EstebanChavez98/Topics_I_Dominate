import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { BeerListComponent } from '../beer-list/beer-list.component';

@Component({
  selector: 'app-add-beer',
  templateUrl: './add-beer.component.html',
  styleUrls: ['./add-beer.component.css']
})
export class AddBeerComponent implements OnInit {
  addBeerForm = new FormGroup({
    name: new FormControl(''),
    alcohol: new FormControl(''),
    description: new FormControl(''),
    brand: new FormControl('')
  })
  isDisabled = false;
  constructor() { }

  ngOnInit() {
  }

  saveBeer(): void{
    console.table(this.addBeerForm.value);
  }
}
