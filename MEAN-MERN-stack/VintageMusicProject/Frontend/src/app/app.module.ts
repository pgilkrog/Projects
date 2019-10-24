import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomepageComponent } from './components/homepage/homepage.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { HttpClientModule } from '@angular/common/http';
import { SignupComponent } from './components/userComponents/signup/signup.component';
import { LoginComponent } from './components/userComponents/login/login.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { UserpageComponent } from './components/userComponents/userpage/userpage.component';
import { CreateMusicianComponent } from './components/musicianComponents/createMusician/createMusician.component';
import { MusicianListComponent } from './components/musicianComponents/musicianList/musicianList.component';
import { MusicianDetailComponent } from './components/musicianComponents/musicianDetails/musicianDetail.component';
import { MusicianItemComponent } from './components/musicianComponents/musicianItem/musicianItem.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    HomepageComponent,
    SignupComponent,
    LoginComponent,
    UserpageComponent,
    MusicianListComponent,
    CreateMusicianComponent,
    MusicianDetailComponent,
    MusicianItemComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
