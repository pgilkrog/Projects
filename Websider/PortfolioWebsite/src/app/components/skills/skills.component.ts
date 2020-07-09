import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-skills',
  templateUrl: './skills.component.html',
  styleUrls: ['./skills.component.css']
})

export class SkillsComponent implements OnInit  {
  skillsFrontend: string[] = [];
  skillsBackend: string[] = [];
  skillsOther: string[] = [];

  ngOnInit() {
    this.skillsFrontend = [
      'Angular',
      'React',
      'Javascript',
      'Typescript',
      'HTML',
      'CSS',
      'WPF / Windforms',
      'Bootstrap',
      'Responsivt Design'
    ];

    this.skillsBackend = [
      'C#',
      'Java',
      '.Net',
      'MSSQL',
      'Firebase',
      'MongoDB',
      'API'
    ];

    this.skillsOther = [
      'Xamarin',
      'Unity',
      'Vuforia(AR)',
      'GIT',
      'Gimp/photoshop',
      'Adobe XD',
      'UML',
      'Agile arbejdsmetoder',
      'Scrum og XP'
    ];
  }
}
