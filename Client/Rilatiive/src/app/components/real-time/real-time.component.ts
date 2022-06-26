import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Contact } from 'src/app/model/Contact';
import { DbService } from 'src/app/services/db.service';

@Component({
  selector: 'app-real-time',
  templateUrl: './real-time.component.html',
  styleUrls: ['./real-time.component.css']
})
export class RealTimeComponent implements OnInit {
  fileToUpload: File | null = null
  form?: Array<Contact> = new Array<Contact>()
  contact: boolean = false
  mysrc: any
  constructor(public dbService: DbService, private router: Router) { }

  ngOnInit(): void {
    this.form = this.dbService.contact;
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

  loading: boolean = false; // Flag variable
  shortLink: string = "";

  uploadFile() {
    this.loading = !this.loading;
    this.dbService.uploadToServer(this.fileToUpload).subscribe(res => {
      if (res == null)
        console.log("Server error")
      else {
        this.dbService.found = res
        this.contact = true
      }
      // 
      //   this.dbService.search().subscribe(
      //     res => {
      //       console.log("res:" + res);
      //       this.dbService.contact = res;
      //       this.contact = true
      //       // this.router.navigate(['Search'])
      //     },
      //     err => {
      //       console.log("error:" + err.message)
      //     })
      // },
      //   err => {
      //     console.log("error:" + err.message);
      //   }
  })


  }

}
