import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-contact-us-form',
  templateUrl: './contact-us-form.component.html',
  styleUrls: ['./contact-us-form.component.css']
})
export class ContactUsFormComponent implements OnInit {
  fileToUpload: File | null = null

  small="assets/small.png"


  constructor() { }

  ngOnInit(): void {
  }
  selectFile(event:any) {
    this.fileToUpload = event.target.files[0];
}

}
