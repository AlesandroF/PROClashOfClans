import { Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { LoginService } from './service/login.service';
import { Login } from './model/login';
import { FormBuilder, FormGroup, FormControl, Validators } from '@angular/forms';
import { AuthModel } from './model/auth.model';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  formLogin: FormGroup;
  login: Login;

  constructor(private loginService: LoginService, private _fb: FormBuilder, private _router: Router) { }

  ngOnInit() {
    this.formBuilder();
  }

  onSubmit() {
    const authUser = AuthModel.CreateInstance(this.Username.value as string, this.Password.value as string);
   
    this.loginService.login(authUser).subscribe(x => {
      localStorage.setItem('token', x.token);
      localStorage.setItem('userId', x.userId);
      this._router.navigate(['/home']);
    });
  }

  goToRegister() {
    this._router.navigate(['/register']);
  }

  get Username() {
    return this.formLogin.controls['Username'];
  }

  get Password() {
    return this.formLogin.controls['Password'];
  }

  getErrorMessage(field: FormControl, fieldName: string) {
    if (field.errors.required) {
      return 'Campo ' + fieldName + ' é obrigatório';
    }
  }

  private formBuilder() {
    this.formLogin = this._fb.group({
      Username: ['', Validators.required],
      Password: ['', Validators.required]
    });
  }
}
