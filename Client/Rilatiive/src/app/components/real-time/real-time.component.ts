import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-real-time',
  templateUrl: './real-time.component.html',
  styleUrls: ['./real-time.component.css']
})
export class RealTimeComponent implements OnInit {
  fileToUpload: File | null = null


  constructor() { }

  ngOnInit(): void {
  }
  selectFile(event:any) {
    this.fileToUpload = event.target.files[0];
}


}
