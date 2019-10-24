import { Component, OnInit, OnDestroy } from '@angular/core';
import { Musician } from 'src/app/models/musician.model';
import { Subscription } from 'rxjs';
import { MusicianService } from 'src/app/services/musician.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-homepage',
  templateUrl: './homepage.component.html',
  styleUrls: ['./homepage.component.css']
})

export class HomepageComponent implements OnInit, OnDestroy {
  musicians: Musician[] = [];
  private musicianSub: Subscription;

  constructor(private mService: MusicianService, private router: Router) { }

  ngOnInit() {
    this.mService.getRandomMusicians();
    this.musicianSub = this.mService.getMusicianListener()
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
