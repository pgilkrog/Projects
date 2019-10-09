import { Component } from '@angular/core';

@Component({
  selector: 'app-homepage',
  templateUrl: './homepage.component.html',
  styleUrls: ['./homepage.component.css']
})
export class HomepageComponent {
  imgSrc = '../../../assets/images/blackWhite.jpg';

  changeImage(isHover: boolean) {
    if (isHover) {
      this.imgSrc = '../../../assets/images/20190318_133411 (2).jpg';
    } else {
      this.imgSrc = '../../../assets/images/blackWhite.jpg';
    }
  }
}
