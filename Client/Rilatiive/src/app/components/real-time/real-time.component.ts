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
  form?: Contact = this.dbService.contact;
  flag: any
  mysrc: any
  constructor(public dbService: DbService, private router: Router) { }

  ngOnInit(): void {
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
    console.log("*********************" + this.fileToUpload);
    this.dbService.uploadToServer(this.fileToUpload).subscribe(res => {
        console.log(res);
        this.flag = false
        this.dbService.search(res).subscribe(res => {
          this.flag = true
          console.log(res);
          this.dbService.contact=res;
        })
      });
      this.router.navigate(['Search'])


  }

}
