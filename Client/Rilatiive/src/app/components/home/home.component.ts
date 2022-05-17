import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  imageLogo="assets/logo2.png"
  // imageApp="assets/image.png"
  im1 ="assets/1.jpg"
  im2 ="assets/2.jpg"
  im3 ="assets/3.jpg"
  im4 ="assets/4.jpg"

  constructor() { }

  ngOnInit(): void {
  }

}
