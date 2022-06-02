import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { SignIn } from 'src/app/model/SignIn';
import { DbService } from 'src/app/services/db.service';
import { Router } from '@angular/router';


@Component({
  selector: 'app-sign-in',
  templateUrl: './sign-in.component.html',
  styleUrls: ['./sign-in.component.css']
})
export class SignInComponent implements OnInit {
  signInForm: any;
  constructor(private db: DbService, private router: Router) { }


  ngOnInit(): void {
    this.signInForm = new FormGroup(
      {
        mail: new FormControl(''),
        pass: new FormControl(''),
      }
    )
  }

  doLogin() {
    console.log(this.signInForm);
    const login: SignIn = {
      Email: this.signInForm.controls.mail.value,
      Password: this.signInForm.controls.pass.value
    }

    console.log(login);
    this.db.loginUser(login).subscribe(res => {
      console.log(res)
      if (res == null)
        alert("Incorrect mail number or password!")
      else {
        alert("Login Successfully!")
        this.db.user = res
        this.router.navigate(['Area'])
      }
    })

  }

}
