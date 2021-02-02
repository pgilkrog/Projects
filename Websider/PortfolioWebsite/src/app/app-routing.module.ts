import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomepageComponent } from './components/homepage/homepage.component';
import { EducationListComponent } from './components/education/education-list/education-list.component';
import { SkillsComponent } from './components/skills/skills.component';
import { AboutComponent } from './components/about/about.component';
import { ProjectListComponent } from './components/projects/project-list/project-list.component';
import { ProjectDetailComponent } from './components/projects/project-detail/project-detail.component';


const routes: Routes = [
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: 'home', component: HomepageComponent,  data: { animation: 'home' }  },
  { path: 'education', component: EducationListComponent,  data: { animation: 'OtherPage' } },
  { path: 'skills', component: SkillsComponent,  data: { animation: 'skills' }  },
  { path: 'projects', component: ProjectListComponent,  data: { animation: 'projects' }  },
  { path: 'about', component: AboutComponent,  data: { animation: 'about' }  },
  { path: 'projects/project/:id', component: ProjectDetailComponent,  data: { animation: 'project' } }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
