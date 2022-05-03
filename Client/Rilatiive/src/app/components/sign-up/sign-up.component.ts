import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { DbService } from 'src/app/services/db.service';
import { SignUp } from 'src/app/model/SignUp';

@Component({
  selector: 'app-sign-up',
  templateUrl:'./sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent implements OnInit {

  signUpForm: any;
  constructor(private db:DbService) { }

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

  
  addUser() {
    console.log(this.signUpForm);
    const signUp: SignUp = {
      FirstName: this.signUpForm.controls.firstName.value,
      LastName: this.signUpForm.controls.lastName.value,
      IdUser: this.signUpForm.controls.id.value,
      Email: this.signUpForm.controls.mail.value,
      Phone: this.signUpForm.controls.phone.value,
      Password: this.signUpForm.controls.pass.value
    }
    console.log(signUp);
    this.db.addUser(signUp).subscribe(res => {
      console.log(res)

      if (res == null)
        alert("Server Routing")
      else
        alert("Added successfully")
    })


  }

  upload(fileInput:any) {
  
   this.db.uploadFile(fileInput.files[0], this.signUpForm.controls.id.value).subscribe();
    console.log("הבוחרים נטענו בהצלחה")
    
  }
}
  
   

