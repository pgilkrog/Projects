import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';

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
    BrowserAnimationsModule
  ],
  exports: [],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
