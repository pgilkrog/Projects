import { Component, OnInit, HostListener } from '@angular/core';
import { transition,
  trigger,
  query,
  style,
  animate,
  group,
  animateChild
} from '@angular/animations';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  animations: [
    trigger('routeAnimations', [
      transition('skills => home, projects => skills, projects => home, project => skills,' +
                'projects => skills, projects => home, project => projects, project => home,' +
                'about => projects, about => skills, about => home', [
        style({ position: 'relative' }),
        query(':enter, :leave', [
          style({
            position: 'absolute',
            top: 0,
            left: 0,
            width: '100%'
          })
        ]),
        query(':enter', [
          style({ left: '-100%' })
        ]),
        query(':leave', animateChild()),
        group([
          query(':leave', [
            animate('300ms ease-out', style({ left: '100%' }))
          ]),
          query(':enter', [
            animate('300ms ease-out', style({ left: '0%' }))
          ])
        ]),
        query(':enter', animateChild()),
      ]),

      transition('home => skills, home => projects, home => about,' +
              'skills => projects, skills => about, projects => about, projects => project,' +
               'project => about', [
        style({ position: 'relative' }),
        query(':enter, :leave', [
          style({
            position: 'absolute',
            top: 0,
            left: 0,
            width: '100%'
          })
        ]),
        query(':enter', [
          style({ left: '100%' })
        ]),
        query(':leave', animateChild()),
        group([
          query(':leave', [
            animate('300ms ease-out', style({ left: '-100%' }))
          ]),
          query(':enter', [
            animate('300ms ease-out', style({ left: '0%' }))
          ])
        ]),
        query(':enter', animateChild()),
      ]),
    ])
  ]
})

export class AppComponent implements OnInit {
  title = 'PortfolioWebsite';
  screenWidth: number;

  ngOnInit() {
    this.getScreenSize();
  }

  @HostListener('window:resize', [])
  getScreenSize() {
    this.screenWidth = window.innerWidth;
  }

  prepareRoute(outlet: RouterOutlet) {
    return outlet && outlet.activatedRouteData && outlet.activatedRouteData.animation;
  }
}
