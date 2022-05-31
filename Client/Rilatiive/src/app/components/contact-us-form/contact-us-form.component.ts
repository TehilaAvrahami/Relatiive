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

  mysrc:any
  constructor(private db: DbService, private router: Router) { }

  ngOnInit(): void {
    this.contactForm = new FormGroup(
      {
        mail: new FormControl(''),
        phone: new FormControl(''),
        img: new FormControl(''),
      }
    )

  }
  selectFile(event: any) {

    console.log(event);

    this.fileToUpload = event.target.files[0];
   
    var reader = new FileReader();
		reader.readAsDataURL(event.target.files[0]);
		
		reader.onload = (_event) => {
			this.mysrc = reader.result; 
		}
  }

  
  addForm() {
    const contact: Contact = {
      Mail: this.contactForm.controls.mail.value,
      ContactPhone: this.contactForm.controls.phone.value,
      image: this.contactForm.controls.img.value,
      userId: this.db.user.IdUser
    }
    
    this.db.addForm(contact).subscribe(res => {
      console.log(res)

      if (res == null)
        alert("Server error")
      else {
        alert("Form successfully created")
      }
    })
    // this.router.navigate(['Contact'])

  }
}