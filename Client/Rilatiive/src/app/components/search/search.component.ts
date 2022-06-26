import { Component, OnInit } from '@angular/core';
import { Contact } from 'src/app/model/Contact';
import { DbService } from 'src/app/services/db.service';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {

  contact: boolean = false
  // form?: Contact = this.dbService.contact;
  constructor(public dbService: DbService) { }
  // ngOnInit(): void {
  //   throw new Error('Method not implemented.');
  // }

  timeLeft: number = 60;
  interval: any;

  ngOnInit(): void {
    // console.log(this.form)
    console.log("oninit search component");

    // this.dbService.search().subscribe(

    //   data => {
    //     this.contact = true
    //     console.log("data:" + data);
    //     this.dbService.contact = data
    //   },
    //   err => {
    //     console.log("error:" + err.message);
    //   }
    // )



    // startTimer() {
    //     this.interval = setInterval(() => {
    //       if(this.timeLeft > 0) {
    //         this.timeLeft--;
    //       } else {
    //         this.timeLeft = 60;
    //       }
    //     },1000)
    //   }

    //   pauseTimer() {
    //     clearInterval(this.interval);
    //   }
  }

}
