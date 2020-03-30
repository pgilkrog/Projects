import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-about',
  templateUrl: './about.component.html',
  styleUrls: ['./about.component.css']
})
export class AboutComponent implements OnInit {
  birthdate: Date = new Date(1990, 3, 30);
  age: any;

  favoritMusic: string[];
  favGames: string[];
  favFilms: string[];
  favSeries: string[];

  ngOnInit() {
    const timeDiff = Math.abs(Date.now() - this.birthdate.getTime());
    this.age = Math.floor((timeDiff / (1000 * 3600 * 24)) / 365.25);

    this.favoritMusic = [
      'Frank Sinatra',
      'Dean Martin',
      'Bing Crosby',
      'Nat King Cole',
      'Louis Armstrong'
    ];
    this.favGames = [
      'Fallout New Vegas',
      'Gothic 2, 3, 1',
      'Vampire: The Masquarede - Bloodlines',
      'Dark Souls, Bloodborne',
      'Elder Scrolls 5, 4, 3'
    ];
    this.favFilms = [
      'Godfather 1, 2',
      'Goodfellas',
      'Casino',
      'Naked Gun 1, 2, 3',
      'Dumb and Dumber',
      'Ace Ventura 1 og 2'
    ];
    this.favSeries = [
      'Breaking Bad',
      'Langt fra Las Vegas',
      'Klovn',
      'Boardwalk Empire',
      'Family Guy',
      'South Park',
      'The Sopranos'
    ];
  }
}
