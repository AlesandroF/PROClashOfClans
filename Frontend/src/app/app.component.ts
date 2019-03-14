import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})

export class AppComponent {
  title = 'Frontend';
  isLogado: boolean = false;

  ngOnInit(): void { }

  get token(): boolean {
    return localStorage.getItem('token') ? true : false;
  }
}
