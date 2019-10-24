import { Component } from '@angular/core';
import { UserService } from 'src/app/services/user.service';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['../login/login.component.css']
})

export class SignupComponent {

  constructor(private userService: UserService) { }

  signup(form: NgForm) {
    this.userService.createUser(form.value.uName, form.value.email, form.value.password);
  }
}
