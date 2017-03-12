import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';
import { DataService } from './dataServices';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  providers: [DataService]
})

export class AppComponent implements OnInit {
  public values: any[];
    public value: string;
  constructor(private _dataService: DataService) { }
  ngOnInit() {
    this._dataService
      .GetAll()
      .subscribe(data => this.values = data,
      error => console.log(error),
      () => console.log('Get all complete'));

      this._dataService
      .GetById()
      .subscribe(data => this.value = data,
      error => console.log(error),
      () => console.log('Get all complete'));
  }
}




interface Product {
  id: string;
  name: string;
  description: string;
  quantity: string;
}

interface Weather {
  temp: string;
  summary: string;
  city: string;
}