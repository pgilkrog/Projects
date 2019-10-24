import { Component, OnInit, OnDestroy } from '@angular/core';
import { MusicianService } from 'src/app/services/musician.service';
import { Musician } from 'src/app/models/musician.model';
import { ActivatedRoute } from '@angular/router';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-musiciandetail',
  templateUrl: './musicianDetail.component.html',
  styleUrls: ['./musicianDetail.component.css']
})

export class MusicianDetailComponent implements OnInit, OnDestroy {
  musician: Musician = new Musician();
  id: string;

  constructor(private musicianService: MusicianService, private route: ActivatedRoute, private uService: UserService) { }

  ngOnInit() {
    this.id = this.route.snapshot.paramMap.get('id');
    this.musicianService.getMusicianById(this.route.snapshot.paramMap.get('id')).subscribe(data => this.musician = data.musician);
  }

  ngOnDestroy() {}

  addFavorite() {
    this.uService.favoriteUser(this.id);
  }

  removeFavorite() {
    this.uService.removeFavorite(this.id);
  }
}
