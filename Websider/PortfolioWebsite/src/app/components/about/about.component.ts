import { Component } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { AngularFireDatabase } from '@angular/fire/database';
import { Email } from 'src/app/models/email';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-about',
  templateUrl: './about.component.html',
  styleUrls: ['./about.component.css']
})
export class AboutComponent {
  emailForm = new FormGroup({
    senderEmail: new FormControl('', [Validators.required, Validators.pattern(/^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/)]),
    subject: new FormControl('', Validators.required),
    content: new FormControl('', Validators.required)
  });

  constructor(private fire: AngularFireDatabase, public datePipe: DatePipe) {}

  sendEmail() {
    const date = Date.now();
    const hejsa = this.datePipe.transform(date, 'yyyy/MM/dd - hh:mm');
    const emailToSend = {
      senderEmail: this.emailForm.value.senderEmail,
      subject: this.emailForm.value.subject,
      content: this.emailForm.value.content,
      dateSend: hejsa
    } as Email;
    if (this.emailForm.valid) {
      this.fire.database.ref('emails').push(emailToSend);
      this.emailForm.reset();
    }

  }
}
