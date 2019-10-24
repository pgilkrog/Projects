import { Component, OnInit } from '@angular/core';
import { UserService } from 'src/app/services/user.service';
import { User } from 'src/app/models/user.model';
import { Musician } from 'src/app/models/musician.model';
import { MusicianService } from 'src/app/services/musician.service';

@Component({
  selector: 'app-userpage',
  templateUrl: './userpage.component.html'
})

export class UserpageComponent implements OnInit {
  user: User = new User();
  musician: Musician = new Musician();

  constructor(private uService: UserService, private mService: MusicianService) { }

  ngOnInit() {
    this.uService.getUser().subscribe(Data => this.user = Data.user);
  }
}
