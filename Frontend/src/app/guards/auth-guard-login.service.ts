import { map, catchError } from 'rxjs/operators';
import { User } from './../layout/login/model/user';
import { LoginService } from './../layout/login/service/login.service';
import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Router } from '@angular/router';
import { Observable, throwError, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthGuardLoginService implements CanActivate {
  public static guards = [];

  constructor(private _authService: LoginService, private _router: Router) { }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<boolean> | boolean {
    this._authService.userIsValid().subscribe(x => {
      this._router.navigate(['/home']);
    });

    return this._authService.userIsValid().pipe(map(x => {
      return of(false);
     }), err => {
      return of(true);
    });
  }

  // usar quando tiver algo que puder ou nao acessar conforme perfil
  static forPermissions(permissions: string | string[]) {
    @Injectable()
    class AuthGuardServiceWithPermissions {
      constructor(private authGuardService: AuthGuardLoginService) { }

      canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<boolean> | boolean {
        let token = localStorage.getItem('token');
        debugger;

        if (!token) {
          this.authGuardService._router.navigate(['/login']);
          return false;
        } else {
          return this.authGuardService.canActivate(route, state) && this.checkPermissions();
        }
      }

      checkPermissions(): Observable<boolean> | boolean {
        const userId = localStorage.getItem('userId');
        if (userId) {
          return this.authGuardService._authService.getCurrentUser(userId).pipe(map((x: User) => {
            let result = permissions.indexOf(x.Role) != -1;

            if (!result) {
              this.authGuardService._router.navigate(['/home']);
            }

            return result;
          }));
        } else {
          return false;
        }
      }
    }

    AuthGuardLoginService.guards.push(AuthGuardServiceWithPermissions);
    return AuthGuardServiceWithPermissions;
  }
}
