import { Component, OnInit, OnDestroy } from '@angular/core';
import { MusicianService } from 'src/app/services/musician.service';
import { Musician } from 'src/app/models/musician.model';
import { Subscription } from 'rxjs';
import { Router } from '@angular/router';

@Component({
  selector: 'app-musicianlist',
  templateUrl: './musicianList.component.html'
})

export class MusicianListComponent implements OnInit, OnDestroy {
  musicians: Musician[] = [];
  private musicianSub: Subscription;

  constructor(private musicianService: MusicianService, private router: Router) { }

  ngOnInit() {
    this.musicianService.getMusicians();
    this.musicianSub = this.musicianService.getMusicianListener()
      .subscribe((musicianData: {musicians: Musician[] }) => {
        this.musicians = musicianData.musicians;
      });
  }

  ngOnDestroy() {
    this.musicianSub.unsubscribe();
  }

  goToDetail(id: string) {
    this.router.navigate(['/MusicianDetail/' + id]);
  }
}
