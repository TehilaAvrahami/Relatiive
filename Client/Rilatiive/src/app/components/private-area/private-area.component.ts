import { Component, OnInit } from '@angular/core';
import { DbService } from 'src/app/services/db.service';
import { Router } from '@angular/router';


@Component({
  selector: 'app-private-area',
  templateUrl: './private-area.component.html',
  styleUrls: ['./private-area.component.css']
})
export class PrivateAreaComponent implements OnInit {

  constructor(public db:DbService, private route:Router) { }
  routeToContact(){
    this.route.navigate(['Contact'])
      }

    routeToSearch(){
    this.route.navigate(['Real'])
      }
  ngOnInit(): void {
  }

}
