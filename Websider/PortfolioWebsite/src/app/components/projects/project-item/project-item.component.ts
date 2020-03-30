import { Component, Input, OnInit } from '@angular/core';
import { Project } from 'src/app/models/project';

@Component({
  selector: 'app-project-item',
  templateUrl: './project-item.component.html',
  styleUrls: ['./project-item.component.css']
})

export class ProjectItemComponent implements OnInit {
  @Input() project: Project;
  imgStyle = {};
  isLoading = true;

  ngOnInit() {
    this.imgStyle = {
      'background-image': 'url(' + this.project.mainImage + ')',
    };

    this.isLoading = false;
  }

  githubLink(url: string) {
    window.location.href = url;
  }
}
