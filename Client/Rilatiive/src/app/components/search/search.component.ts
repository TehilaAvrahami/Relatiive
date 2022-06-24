import { Component, OnInit } from '@angular/core';
import { Contact } from 'src/app/model/Contact';
import { DbService } from 'src/app/services/db.service';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {

  flag: boolean = false
  form?: Contact = this.dbService.contact;
  constructor(public dbService: DbService) { }
  // ngOnInit(): void {
  //   throw new Error('Method not implemented.');
  // }

  ngOnInit(): void {
    console.log(this.form)
  }

}
