import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomepageComponent } from './components/homepage/homepage.component';
import { LoginComponent } from './components/userComponents/login/login.component';
import { UserpageComponent } from './components/userComponents/userpage/userpage.component';
import { SignupComponent } from './components/userComponents/signup/signup.component';
import { CreateMusicianComponent } from './components/musicianComponents/createMusician/createMusician.component';
import { MusicianListComponent } from './components/musicianComponents/musicianList/musicianList.component';
import { MusicianDetailComponent } from './components/musicianComponents/musicianDetails/musicianDetail.component';


const routes: Routes = [
  { path: '', redirectTo: 'Home', pathMatch: 'full' },
  { path: 'Home', component: HomepageComponent },
  { path: 'Login', component: LoginComponent },
  { path: 'Signup', component: SignupComponent },
  { path: 'Userpage', component: UserpageComponent },
  { path: 'MusiciansList', component: MusicianListComponent },
  { path: 'MusicianDetail/:id', component: MusicianDetailComponent },
  { path: 'CreateMusician', component: CreateMusicianComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
