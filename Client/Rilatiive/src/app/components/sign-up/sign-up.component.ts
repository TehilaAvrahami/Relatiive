import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { DbService } from 'src/app/services/db.service';
import { SignUp } from 'src/app/model/SignUp';
import { Router } from '@angular/router';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent implements OnInit {

  signUpForm: any;

  fileToUpload: File | null = null

  constructor(private db: DbService, private router: Router) { }

  ngOnInit(): void {
    this.signUpForm = new FormGroup(
      {
        firstName: new FormControl('', [Validators.required]),
        lastName: new FormControl('', [Validators.required]),
        id: new FormControl('', [Validators.required, Validators.maxLength(8), Validators.minLength(8)]),
        mail: new FormControl('', [Validators.required, Validators.email]),
        phone: new FormControl('', [Validators.required]),
        pass: new FormControl('', [Validators.required]),
      }
    )
  }

  addUser() {
    const signUp: SignUp = {
      FirstName: this.signUpForm.controls.firstName.value,
      LastName: this.signUpForm.controls.lastName.value,
      Id: this.signUpForm.controls.id.value,
      Email: this.signUpForm.controls.mail.value,
      Phone: this.signUpForm.controls.phone.value,
      Password: this.signUpForm.controls.pass.value
    }
    
    this.db.addUser(signUp).subscribe(res => {
      console.log(res)

      if (res == null)
        alert("Server error")
      else {
        this.db.user = res
        alert("Added successfully")
      }
    })
    this.router.navigate(['Contact'])
  }



}



