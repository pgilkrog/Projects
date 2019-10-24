import { Component, Input, OnInit } from '@angular/core';
import { Musician } from 'src/app/models/musician.model';

@Component({
  selector: 'app-musicianitem',
  templateUrl: 'musicianItem.component.html',
  styleUrls: ['musicianItem.component.css']
})

export class MusicianItemComponent implements OnInit {
  @Input() musician: Musician;
  imgStyle = {};

  ngOnInit() {
    this.imgStyle = {
      'background-image': 'url(' + this.musician.image + ')',
    };
  }
}
