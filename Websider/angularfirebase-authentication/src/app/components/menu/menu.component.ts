import { Component, OnInit } from '@angular/core';
import { AuthService } from 'src/app/shared/services/auth.service';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit {
  isExpanded = false;
  isLoggedIn: boolean = false;

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    if (this.isExpanded)
      this.collapse()
    else
      this.isExpanded = !this.isExpanded;
  }

  constructor(private authService: AuthService) { }

  ngOnInit() {
    this.isLoggedIn = this.authService.isLoggedIn;
  }

}
