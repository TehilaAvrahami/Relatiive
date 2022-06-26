import { Component, OnInit } from '@angular/core';
import { DbService } from 'src/app/services/db.service';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Contact } from 'src/app/model/Contact';
import { Router } from '@angular/router';


@Component({
  selector: 'app-contact-us-form',
  templateUrl: './contact-us-form.component.html',
  styleUrls: ['./contact-us-form.component.css']
})
export class ContactUsFormComponent implements OnInit {
  contactForm: any;
  fileToUpload: File | null = null
  small = "assets/small.png"
  control = new FormControl();

  dbService: any;
  constructor(public db: DbService, private router: Router) { }

  ngOnInit(): void {
    this.contactForm = new FormGroup(
      {
        mail: new FormControl('', [Validators.required, Validators.email]),
        phone: new FormControl('', [Validators.required]),
      }
    )
  }


  addForm() {
    const contact: Contact = {
      Mail: this.contactForm.controls.mail.value,
      ContactPhone: this.contactForm.controls.phone.value,
      IdUser: this.db.user.IdUser
    }

    //בדיקת תקינות

    // if(!contact.Mail.includes("@") ||!contact.Mail.includes(".")  )
    // {
    //   alert("כתובת מייל לא נכונה");
    // }




    //שליחה לשרת
    this.db.addform(contact).subscribe(res => {
      console.log(res)
      if (this.db.user.IdUser == null)
        alert("Invalid login")
      if (res == null)
        alert("Server error")
      else {
        alert("Form successfully created")
      }
    })
    this.router.navigate(['Area'])
  }


  

}