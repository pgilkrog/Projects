import { Component, OnInit } from '@angular/core';
import { ProjectService } from 'src/app/services/project.service';
import { Project } from 'src/app/models/project';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { Observable } from 'rxjs';
import {map, startWith} from 'rxjs/operators';
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
  form: FormGroup;

  myControl = new FormControl();
  options: string[] = ['Angular',
                        'React',
                        'C#',
                        '.Net',
                        'HTML',
                        'CSS',
                        'Bootstrap',
                        'Java',
                        'Typescript',
                        'Xamarin',
                        'Javascript',
                        'SQL',
                        'Unity',
                        'API',
                        'NodeJS',
                        'MongoDB'
                      ];
  filteredOptions: Observable<string[]>;

  constructor(private service: ProjectService) {}

  ngOnInit() {
    this.projectsList = this.service.getProjects();
    this.filteredList = this.service.getProjects();

    this.form = new FormGroup({
      search: new FormControl(null, {
        validators: [Validators.required]
      })
    });

    this.filteredOptions = this.myControl.valueChanges.pipe(
      startWith(''),
      map(value => this._filter(value))
    );
  }

  private _filter(value: string): string[] {
    const filterValue = value.toLowerCase();
    return this.options.filter(option => option.toLowerCase().includes(filterValue));
  }

  filterProjects() {
    // this.filteredList.pop();
    // let temp = false;
    // for (let i = 0; i < this.projectsList.length; i++) {
    //   const project = this.projectsList[i];
    //   for (const item of project.technologies) {
    //     if (item === this.myControl.value) {
    //       temp = true;
    //     }
    //   }
    //   if(!temp){
    //     this.filteredList = this.filteredList.slice(i, 1);
    //   }
    // }
    this.filteredList = this.service.getProjectsBySearch(this.myControl.value);
  }
}
