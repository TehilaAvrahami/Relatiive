import { Component, OnInit } from '@angular/core';
import { DbService } from 'src/app/services/db.service';

@Component({
  selector: 'app-real-time',
  templateUrl: './real-time.component.html',
  styleUrls: ['./real-time.component.css']
})
export class RealTimeComponent implements OnInit {
  fileToUpload: File | null = null

  mysrc: any
  constructor(public dbService: DbService) { }

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
    this.dbService.upload(this.fileToUpload).subscribe(

      res => { console.log(res) }
    );
  }

}