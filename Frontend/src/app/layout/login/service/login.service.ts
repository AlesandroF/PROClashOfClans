import { Injectable } from '@angular/core';
import { BaseService } from '../../../_services/base-service';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { AuthModel } from '../model/auth.model';

@Injectable()
export class LoginService extends BaseService {

  constructor(_http: HttpClient) {
    super(_http);
  }

  userIsValid(): Observable<boolean> {
    return this.doGet('authentication');
  }

  login(authUser: AuthModel): Observable<any> {
    return this.doPost('authentication', authUser);
  }

  getCurrentUser(userId: string) {
    return this.doGet('authentication/currentUser/' + userId);
  }
}
