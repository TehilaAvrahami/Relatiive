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
        firstName: new FormControl(''),
        lastName: new FormControl(''),
        id: new FormControl(''),
        mail: new FormControl(''),
        phone: new FormControl(''),
        pass: new FormControl(''),
      }
    )
  }
  selectFile(event: any) {
    this.fileToUpload = event.target.files[0];
  }
  addUser() {
    const signUp: SignUp = {
      FirstName: this.signUpForm.controls.firstName.value,
      LastName: this.signUpForm.controls.lastName.value,
      IdUser: this.signUpForm.controls.id.value,
      Email: this.signUpForm.controls.mail.value,
      Phone: this.signUpForm.controls.phone.value,
      Password: this.signUpForm.controls.pass.value
    }
    this.db.addUser(signUp).subscribe(res => {
      console.log(res)

      if (res == null)
        alert("Server error")
      else {
        alert("Added successfully")
      }
    })
    this.router.navigate(['Contact'])


  }

  upload(fileInput: any) {

    this.db.uploadFile(fileInput.files[0], this.signUpForm.controls.id.value).subscribe();
    // console.log("הבוחרים נטענו בהצלחה")

  }
}



