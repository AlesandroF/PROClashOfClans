import { Injectable, NgModule } from '@angular/core';
import { HttpInterceptor, HttpRequest, HttpHandler, HttpEvent, HTTP_INTERCEPTORS, HttpErrorResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map, finalize, catchError } from 'rxjs/operators';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrManager } from 'ng6-toastr-notifications';
import { throwError } from 'rxjs';

@Injectable()
export class HttpRequestInterceptor implements HttpInterceptor {
    constructor(private spinner: NgxSpinnerService, private _toastr: ToastrManager) { }

    intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        let token = localStorage.getItem('token');

        const headers = req.headers
            .set('Content-Type', 'application/json')
            .set('Authorization', `Bearer ${token}`)
            .set('Access-Control-Allow-Origin', '*')
            .set('Access-Control-Allow-Headers', '*')
            .set('Access-Control-Expose-Headers', '*')
            .set('Access-Control-Allow-Methods', 'GET, POST, DELETE, PUT')
            .set('Access-Control-Allow-Credentials', 'true');

        this.spinner.show();

        const cloneReq = req.clone({ headers });

        return next.handle(cloneReq).pipe(
            map(res => {
                return res;
            }),
            catchError((err: HttpErrorResponse) => {
                if(!err.error) {
                   // this._toastr.errorToastr("Algo de errado não esta certo...", 'Oops!');
                } else {
                   // this._toastr.errorToastr(err.error.text ? err.error.text : err.error, 'Oops!');
                }
                return throwError(err);
            }),
            finalize(() => this.spinner.hide()),
        );
    }
}

@NgModule({
    providers: [
        {
            provide: HTTP_INTERCEPTORS,
            useClass: HttpRequestInterceptor,
            multi: true
        }
    ]
})
export class HttpRequestInterceptorModule { }
