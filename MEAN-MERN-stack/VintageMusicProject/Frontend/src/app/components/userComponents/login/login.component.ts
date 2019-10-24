import { Component, OnInit, OnDestroy } from '@angular/core';
import { UserService } from 'src/app/services/user.service';
import { NgForm } from '@angular/forms';
import { Subscription } from 'rxjs';
import { TouchSequence } from 'selenium-webdriver';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})

export class LoginComponent implements OnInit, OnDestroy {
  private authStatusSub: Subscription;

  constructor(private userService: UserService) { }

  ngOnInit() {
    this.authStatusSub = this.userService
      .getAuthStatusListener()
      .subscribe(
        authStatus => {

        }
      );
  }

  ngOnDestroy() {
    this.authStatusSub.unsubscribe();
  }

  login(form: NgForm) {
    this.userService.login(form.value.email, form.value.password);
  }

}
