import {
  trigger, state, style, transition,
  animate, group, query, stagger, keyframes, animateChild
} from '@angular/animations';

export const projectSlide = [
  trigger('listAnimation', [
    transition('* => *', [

    query(':enter', style({ opacity: 0 }), {optional: true}),

    query(':enter', stagger('300ms', [
    animate('1s ease-in', keyframes([
      style({opacity: 0, transform: 'translateX(-75%)', offset: 0}),
      style({opacity: .5, transform: 'translateX(35px)',  offset: 0.3}),
      style({opacity: 1, transform: 'translateX(0)',     offset: 1.0}),
    ]))]), {optional: true}),

    query(':leave', stagger('300ms', [
    animate('1s ease-in', keyframes([
      style({opacity: 1, transform: 'translateX(0)', offset: 0}),
      style({opacity: .5, transform: 'translateX(35px)',  offset: 0.3}),
      style({opacity: 0, transform: 'translateX(-75%)',     offset: 1.0}),
    ]))]), {optional: true})
    ])
  ])
];
