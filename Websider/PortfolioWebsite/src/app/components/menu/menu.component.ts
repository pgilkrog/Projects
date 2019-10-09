import { Component } from '@angular/core';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent {
  showMenu = false;

  toggleMenu() {
    if (!this.showMenu) {
      this.showMenu = true;
    } else {
      this.showMenu = false;
    }
  }
}
