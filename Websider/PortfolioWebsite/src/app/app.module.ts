import { BrowserModule } from '@angular/platform-browser';
import 'hammerjs';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { MaterialModule } from './material.module';

import { AppComponent } from './app.component';
import { MenuComponent } from './components/menu/menu.component';
import { HomepageComponent } from './components/homepage/homepage.component';
import { EducationListComponent } from './components/education/education-list/education-list.component';
import { EducationItemComponent } from './components/education/education-item/education-item.component';
import { SkillsComponent } from './components/skills/skills.component';
import { AboutComponent } from './components/about/about.component';
import { ProjectListComponent } from './components/projects/project-list/project-list.component';
import { ProjectItemComponent } from './components/projects/project-item/project-item.component';
import { ProjectDetailComponent } from './components/projects/project-detail/project-detail.component';
import { NavbarComponent } from './components/navbar/navbar.component';

import { AngularFireModule } from '@angular/fire';
import { AngularFireDatabaseModule } from '@angular/fire/database';
import { DatePipe } from '@angular/common';

const config = {
  apiKey: 'AIzaSyDdJ13wVetNUSW09uvIWoY94KaHrQfm30w',
  authDomain: 'pawportfolio-b84d3.firebaseapp.com',
  databaseURL: 'https://pawportfolio-b84d3.firebaseio.com',
  projectId: 'pawportfolio-b84d3',
  storageBucket: 'pawportfolio-b84d3.appspot.com',
  messagingSenderId: '641609071420'
};

@NgModule({
  declarations: [
    AppComponent,
    MenuComponent,
    NavbarComponent,
    HomepageComponent,
    EducationListComponent,
    EducationItemComponent,
    SkillsComponent,
    AboutComponent,
    ProjectListComponent,
    ProjectItemComponent,
    ProjectDetailComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MaterialModule,
    ReactiveFormsModule,
    AngularFireModule.initializeApp(config),
    AngularFireDatabaseModule
  ],
  exports: [

  ],
  providers: [DatePipe],
  bootstrap: [AppComponent]
})
export class AppModule { }
