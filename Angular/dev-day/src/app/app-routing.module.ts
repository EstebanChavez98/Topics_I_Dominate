import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AddUserComponent } from './Components/add-user/add-user.component';
import { UserListComponent } from './Components/user-list/user-list.component';
import { PageNotFoundComponent } from './page/page-not-found/page-not-found.component';


const routes: Routes = [
  { path: 'add-user', component: AddUserComponent },
  { path: 'user-list', component: UserListComponent },
  { path: '', redirectTo: '/add-user', pathMatch: 'full'},
  { path: '*', component: PageNotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
