import { Component, OnInit, OnDestroy } from '@angular/core';
import { UserService } from 'src/app/services/user.service';
import { Subscription } from 'rxjs';
import { User } from 'src/app/models/user.model';
import { Router } from '@angular/router';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})

export class NavbarComponent implements OnInit, OnDestroy {
  user: User = new User();
  userIsAuthenticated = false;
  private authListenerSubs: Subscription;

  constructor(private userService: UserService, private router: Router) { }

  ngOnInit() {
    this.userService.autoAuthUser();
    if (this.userService.autoAuthUser) {
      this.userIsAuthenticated = true;
    }
    this.userIsAuthenticated = this.userService.getIsAuth();
    this.authListenerSubs = this.userService
      .getAuthStatusListener()
      .subscribe(isAuthenticated => {
        this.userIsAuthenticated = isAuthenticated;
        this.userService.getUser().subscribe(data => this.user = data.user);
      });
    if (this.userIsAuthenticated) {
      this.userService.getUser().subscribe(data => this.user = data.user);
    }
  }

  goToUserpage() {
    this.router.navigate(['Userpage']);
  }

  ngOnDestroy() {
    this.authListenerSubs.unsubscribe();
  }

  logout() {
    this.userService.logout();
  }
}
