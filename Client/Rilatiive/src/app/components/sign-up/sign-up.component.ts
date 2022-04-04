import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-sign-up',
  templateUrl:'./sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent implements OnInit {

  signUpForm: any;
  constructor() { }

  ngOnInit(): void {
    this.signUpForm = new FormGroup(
      {
        firstName: new FormControl(''),
        name: new FormControl(''),
        pass: new FormControl(''),
        nochange: new FormControl(''),
        change: new FormControl(''),
      


      }
    )
  }


  
   
}
