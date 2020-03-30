import {COMMA, ENTER} from '@angular/cdk/keycodes';
import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { ProjectService } from 'src/app/services/project.service';
import { Project } from 'src/app/models/project';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { Observable } from 'rxjs';
import {map, startWith} from 'rxjs/operators';
import { trigger, style, transition, animate, keyframes, query, stagger } from '@angular/animations';
import {MatAutocompleteSelectedEvent, MatAutocomplete} from '@angular/material/autocomplete';
import {MatChipInputEvent} from '@angular/material/chips';


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

  // visible = true;
  // selectable = true;
  // removable = true;
  // separatorKeysCodes: number[] = [ENTER, COMMA];
  // filtersCtrl = new FormControl();
  // filteredTechs: Observable<string[]>;
  // filters: string[] = [];
  // allFilters: string[] = ['Angular',
  //                         'React',
  //                         'C#',
  //                         '.Net',
  //                         'HTML',
  //                         'CSS',
  //                         'Bootstrap',
  //                         'Java',
  //                         'Typescript',
  //                         'Xamarin',
  //                         'Javascript',
  //                         'Material',
  //                         'SQL',
  //                         'MSSQL',
  //                         'Unity',
  //                         'API',
  //                         'NodeJS',
  //                         'MongoDB'
  //                      ];

  // @ViewChild('techInput', {static: false}) techInput: ElementRef<HTMLInputElement>;
  // @ViewChild('auto', {static: false}) matAutocomplete: MatAutocomplete;

  constructor(private service: ProjectService) {}

  ngOnInit() {
    this.projectsList = this.service.getProjects();
    this.filteredList = this.service.getProjects();

    for (const item of this.projectsList) {
      this.sortingstuff(item);
    }

    // this.filteredTechs = this.filtersCtrl.valueChanges.pipe(
    //     startWith(null),
    //     map((tech: string | null) => tech ? this._filter(tech) : this.allFilters.slice()));
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

  // add(event: MatChipInputEvent): void {
  //   // Add tech only when MatAutocomplete is not open
  //   // To make sure this does not conflict with OptionSelected Event
  //   if (!this.matAutocomplete.isOpen) {
  //     const input = event.input;
  //     const value = event.value;

  //     // Add our tech
  //     if ((value || '').trim()) {
  //       this.filters.push(value.trim());
  //     }

  //     // Reset the input value
  //     if (input) {
  //       input.value = '';
  //     }

  //     this.filtersCtrl.setValue(null);
  //   }

  //   this.filterProjects();
  // }

  // remove(tech: string): void {
  //   const index = this.filters.indexOf(tech);

  //   if (index >= 0) {
  //     this.filters.splice(index, 1);
  //   }

  //   this.filterProjects();
  // }

  // selected(event: MatAutocompleteSelectedEvent): void {
  //   this.filters.push(event.option.viewValue);
  //   this.techInput.nativeElement.value = '';
  //   this.filtersCtrl.setValue(null);
  // }

  // private _filter(value: string): string[] {
  //   const filterValue = value.toLowerCase();
  //   return this.allFilters.filter(tech => tech.toLowerCase().indexOf(filterValue) === 0);
  // }

  // filterProjects() {
  //   this.filteredList = this.service.getProjectsBySearch(this.filters);
  // }
}
