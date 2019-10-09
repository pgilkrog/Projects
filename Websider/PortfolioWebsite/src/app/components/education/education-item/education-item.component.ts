import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-education-item',
  templateUrl: './education-item.component.html',
  styleUrls: ['./education-item.component.css']
})

export class EducationItemComponent {
  @Input() title: string;
  @Input() content: string;

  isExpanded = false;

  toggleExpansion() {
    if (this.isExpanded) {
      this.isExpanded = false;
    } else {
      this.isExpanded = true;
    }
  }
}
