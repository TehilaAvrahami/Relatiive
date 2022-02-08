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
        tz: new FormControl(''),
        name: new FormControl(''),
        pass: new FormControl(''),
        nochange: new FormControl(''),
        change: new FormControl(''),
      


      }
    )
  }


  //   <!-- שם משפחה -->
  //   <!-- גיל  -->
  //   <!-- תאריך לידה -->
  //   <!--טלפון -->
  //   <!-- מייל -->
  //   <!-- תז -->

  //   <!-- שם משתמש לאתר -->
  //   <!--סיסמא -->
  //   <!--אימות סיסמא -->
  //   <!-- אישור תנאי השימוש -->
  // 
}
