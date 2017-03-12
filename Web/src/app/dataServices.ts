import { Http, Response, Headers } from '@angular/http';
import 'rxjs/add/operator/map'
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/do';
//import { Configuration } from '../app.constants';
import { Injectable } from "@angular/core";
import { } from './product/'


@Injectable()
export class DataService {
    private actionUrl: string;
    private actionUrl1: string;
    constructor(private _http: Http) {
        this.actionUrl = 'http://localhost:56989/api/product/';
        this.actionUrl1 = 'http://localhost:56989/api/product/1';
    }

    public GetAll = (): Observable<string[]> => {
        return this._http.get(this.actionUrl)
            .map((response: Response) => <string[]>response.json())
            .do(x => console.log(x));
    }
    public GetById = (): Observable<string> => {
        return this._http.get(this.actionUrl1)
            .map((response: Response) => <string>response.json())
            .do(x => console.log(x));
    }
}