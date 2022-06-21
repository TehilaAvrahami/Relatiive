import { Component, OnInit } from '@angular/core';
import { DbService } from 'src/app/services/db.service';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {

  flag: boolean = false

  constructor(public dbService: DbService) { }

  ngOnInit(): void {
    this.dbService.search("").subscribe(
      res => {
        this.flag = true
        this.dbService.foundId = res;

      },
      err => {
        console.log("error:" + err.message);
      }
    )
  }

}
