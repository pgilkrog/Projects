import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Project } from 'src/app/models/project';
import { ProjectService } from 'src/app/services/project.service';

@Component({
  selector: 'app-project-detail',
  templateUrl: './project-detail.component.html',
  styleUrls: ['./project-detail.component.css']
})
export class ProjectDetailComponent implements OnInit {
  id: number;
  project: Project;

  constructor(private router: ActivatedRoute, private service: ProjectService) {}

  ngOnInit() {
    this.project = this.service.getProjectById(+this.router.snapshot.paramMap.get('id'));
  }
}
