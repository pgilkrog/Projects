import { Component, OnInit } from '@angular/core';
import { ProjectService } from 'src/app/services/project.service';
import { Project } from 'src/app/models/project';
import { trigger, style, transition, animate, keyframes, query, stagger } from '@angular/animations';


@Component({
  selector: 'app-project-list',
  templateUrl: 'project-list.component.html',
  styleUrls: ['./project-list.component.css'],
  animations: [
    trigger('listAnimation', [
      transition('* => *', [
        query(':enter', style({ opacity: 0 }), {optional: true}),

        query(':enter', stagger('300ms', [
          animate('1s ease-in', keyframes([
            style({opacity: 0, transform: 'translateX(-75%)', offset: 0}),
            style({opacity: .5, transform: 'translateX(35px)', offset: 0.3}),
            style({opacity: 1, transform: 'translateX(0)', offset: 1.0}),
          ]))]), {optional: true}),

          query(':leave', stagger('300ms', [
            animate('1s ease-in', keyframes([
              style({opacity: 1, transform: 'translateX(0)', offset: 0}),
              style({opacity: .5, transform: 'translateX(35px)', offset: 0.3}),
              style({opacity: 0, transform: 'translateX(-75%)', offset: 1.0}),
            ]))]), {optional: true})
      ])
    ])
  ]
})

export class ProjectListComponent implements OnInit {
  projectsList: Project[] = [];
  filteredList: Project[] = [];

  semesterProjects: Project[] = [];
  unityProjects: Project[] = [];
  webintProjecst: Project[] = [];
  softwareProjects: Project[] = [];
  websiteProjects: Project[] = [];

  constructor(private service: ProjectService) {}

  ngOnInit() {
    this.projectsList = this.service.getProjects();
    this.filteredList = this.service.getProjects();

    for (const item of this.projectsList) {
      this.sortingstuff(item);
    }
  }

  sortingstuff(item: Project) {
    switch (item.type) {
      case 'Semester':
        this.semesterProjects.push(item);
        break;
      case 'Webintegrator':
        this.webintProjecst.push(item);
        break;
      case 'Software':
        this.softwareProjects.push(item);
        break;
      case 'Website':
        this.websiteProjects.push(item);
        break;
      case 'Unity':
        this.unityProjects.push(item);
        break;
      default:
        return;
    }
  }
}
