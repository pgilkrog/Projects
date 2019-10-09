import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-about',
  templateUrl: './about.component.html',
  styleUrls: ['./about.component.css']
})
export class AboutComponent implements OnInit {
  favoritMusic: string[];
  favGames: string[];
  favFilms: string[];
  favSeries: string[];

  ngOnInit() {
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
