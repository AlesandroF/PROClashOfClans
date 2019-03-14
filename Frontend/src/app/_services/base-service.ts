import { environment } from './../../environments/environment';
import { Headers } from '@angular/http';

import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';


export abstract class BaseService {

    public headers = new Headers();

    constructor(private _http: HttpClient) { }

    /*doGet<T>(method: string): Observable<T> {
        this.contentTypeApplicationJson(this.headers);
        return this.http
            .get(this.BasePath() + method, { headers: this.headers }).pipe(
                map(response => this.GetResponse<T>(response)));
    }

    doGetAny(method: string): Observable<any> {
        this.contentTypeApplicationJson(this.headers);

        return this.http.get(this.BasePath() + method, { headers: this.headers });
    }

    doPut<T>(object: T, method: string): Observable<T> {
        this.contentTypeApplicationJson(this.headers);

        const url = this.BasePath() + method;
        const body = this.ConvertParamsJSON<T>(object);

        return this.http
            .put(url, body, { headers: this.headers }).pipe(
                map(response => { console.log(response); return this.GetResponse<T>(response); }));
    }*/

    protected doPost(path: string, body: any): Observable<any> {
        return this._http.post(environment.apiUrl + path, body);
    }

    protected doGet(path: string): Observable<any> {
        return this._http.get(environment.apiUrl + path);
    }

    /*doPost<T>(object: T, method: string): Observable<any> {
        this.contentTypeApplicationJson(this.headers);

        const url = this.BasePath() + method;
        const body = this.ConvertParamsJSON<T>(object);

        return this.http.post(url, body, { headers: this.headers }).pipe(
            map(response => {
                try {
                    return this.GetResponse<T>(response);
                } catch (error) {
                    return null;
                }
            }));
    }*/

    /* contentTypeApplicationJson(headers: Headers) {
         headers.append('Content-Type', 'application/json');
     }
 
     contentTypeApplicationFormUrlEncoded(headers: Headers) {
         headers.append('Content-Type', 'application/x-www-form-urlencoded');
     }
 
     BasePath(): string {
         return this.API;
     }
 
     GetResponse<T>(response: Response) {
         try {
             return response.json() as T;
         } catch (err) {
             return null;
         }
     }
 
     handleError(error: any): Observable<any> {
         console.error('An error occurred', error.toString()); // for demo purposes only
         let details;
         let response;
         try {
             details = error.json();
             if (details.message) {
                 response = details;
             } else {
                 response = JSON.parse(details);
             }
         } catch (error) {
             response = details;
         }
         return Observable.throw(response || { 'Message': '' + details });
     }
 
     ConvertParamsJSON<T>(body: T): string {
         return JSON.stringify(body);
     }*/
}
