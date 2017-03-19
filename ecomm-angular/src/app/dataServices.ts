import { Http, Response, Headers } from '@angular/http';
import 'rxjs/add/operator/map'
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/do';
//import { Configuration } from '../app.constants';
import { Injectable } from "@angular/core";
import {} from './product/'


@Injectable()
export class DataService { 
  private actionUrl: string;
  private actionUrl1: string;

  constructor(private _http: Http) {
    this.actionUrl = 'http://localhost:56990/api/product/';

 
 
    
}

public GetAll = (): Observable<string[]> => {
    
    return this._http.get(this.actionUrl)
        .map((response: Response) => <string[]>response.json())
        .do(x => console.log(x));
}
public GetById = (idval:string): Observable<string> => {
    this.actionUrl1 = 'http://localhost:56990/api/product/' + idval;
    return this._http.get(this.actionUrl1)
        .map((response: Response) =>response.json())
        .do(x => console.log(x));
      
}
}