import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { Musician } from '../models/musician.model';
import { map } from 'rxjs/operators';
import { Subject } from 'rxjs';
import { connectableObservableDescriptor } from 'rxjs/internal/observable/ConnectableObservable';

const BACKEND_URL = environment.apiUrl + 'musician';

@Injectable({ providedIn: 'root' })


export class MusicianService {
  private musicians: Musician[] = [];
  private musiciansUpdated = new Subject<{musicians: Musician[]}>();
  private demmus = false;

  constructor(private http: HttpClient, private router: Router) { }

  getMusicianListener() {
    return this.musiciansUpdated.asObservable();
  }

  getMusicians() {
    this.http.get<{ musicians: any }>(BACKEND_URL).pipe(map((musicianData) => {
      return { musicians: musicianData.musicians.map(musician => {
        return {
          id: musician._id,
          name: musician.name,
          realname: musician.realname,
          description: musician.description,
          image: musician.image,
          brith: musician.birth,
          death: musician.death
        };
      })};
    }))
    .subscribe(data => {
      this.musicians = data.musicians;
      this.musiciansUpdated.next({
        musicians: [...this.musicians]
      });
    });
  }

  getRandomMusicians() {
    this.http.get<{ musicians: any }>(BACKEND_URL + '/random').pipe(map((musicianData) => {
      return { musicians: musicianData.musicians.map(musician => {
        return {
          id: musician._id,
          name: musician.name,
          realname: musician.realname,
          description: musician.description,
          image: musician.image,
          brith: musician.birth,
          death: musician.death
        };
      })};
    }))
    .subscribe(data => {
      this.musicians = data.musicians;
      this.musiciansUpdated.next({
        musicians: [...this.musicians]
      });
    });
  }

  getMusicianById(id: string) {
    return this.http.get<{ musician: Musician }>(BACKEND_URL + '/' + id);
  }

  getdemmusicians() {
    if (!this.demmus) {
      this.getMusicians();
    }

    return this.musiciansUpdated;
  }

  createMusician(musician: Musician, image: File) {
    const musicianData = new FormData();
    musicianData.append('name', musician.name);
    musicianData.append('realname', musician.realname);
    musicianData.append('description', musician.description);
    musicianData.append('birth', musician.birth.toString());
    musicianData.append('death', musician.death.toString());
    musicianData.append('image', image);

    console.log(musician);

    this.http.post<{ respons: string }>(BACKEND_URL, musicianData).subscribe(responseDate => {
      return responseDate.respons;
    });
  }
}
