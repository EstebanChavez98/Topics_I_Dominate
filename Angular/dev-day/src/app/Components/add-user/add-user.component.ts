import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { User } from 'src/app/shared/interfaces/user';

@Component({
  selector: 'app-add-user',
  templateUrl: './add-user.component.html',
  styleUrls: ['./add-user.component.css']
})
export class AddUserComponent implements OnInit {
  addUserForm = new FormGroup({
    firstName: new FormControl(''),
    lastName: new FormControl(''),
    age: new FormControl(''),
    cellphone: new FormControl(''),
    email: new FormControl('')
  })

  isDisabled = false;
  constructor() { }

  ngOnInit() {
  }

  toggleDisable(){
    this.isDisabled = !this.isDisabled;
  }
  saveUser(): void{
    console.table(this.addUserForm.value)
  }

}
