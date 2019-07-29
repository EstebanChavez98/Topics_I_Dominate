import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/shared/interfaces/user';
//import { User } from './../../shared/interfaces/user';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.css']
})
export class UserListComponent implements OnInit {
  userList:User[] = [
    {
      firstName: 'Esteban', lastName: 'Chavez', age: 20, 
      cellphone: '6672994440', email: 'esteban.ch.v95@gmail.com'
    },
    {
      firstName: 'Liliana', lastName: 'Valenzuela', age: 20, 
      cellphone: '6674829312', email: 'lili98@gmail.com'
    },
    {
      firstName: 'David', lastName: 'Verdugo', age: 23, 
      cellphone: '6674829312', email: 'davidverdugogonzalez@gmail.com'
    }
  ];

  constructor() { }

  ngOnInit() {
  }

}
