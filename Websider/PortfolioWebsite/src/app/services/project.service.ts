import { Project } from '../models/project';
import projectsData from '../../assets/data/projectData.json';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ProjectService {
  private projects: Project[] = [];

  getProjects() {
    return projectsData.projects;
  }

  getProjectById(id: number) {
    for (const project of projectsData.projects) {
      if (project.id === id) {
        return project;
      }
    }
  }

  getProjectsBySearch(search: string) {
    this.projects = [];
    const tempPor = projectsData.projects;

    for (const project of tempPor) {
      if (project.description.includes(search)) {
        this.projects.push(project);
      } else {
        for (const item of project.technologies) {
          if (item === search) {
            this.projects.push(project);
          }
        }
      }
    }

    return this.projects;
  }
}
