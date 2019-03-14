import { MenuLayoutModule } from './layout/menu/menu-layout.module';
import { AuthGuardService } from './guards/auth-guard.service';
import { AppRoutingModule } from './app-routing.module';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { HttpModule } from '@angular/http';
import { FormsModule } from '@angular/forms';
import { LoginModule } from './layout/login/login.module';
import { NgxSpinnerModule } from 'ngx-spinner';
import { HttpRequestInterceptorModule } from './interceptor/http-interceptor';
import { HomeModule } from './home/home.module';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { ToastrModule } from 'ng6-toastr-notifications';
import { RegisterModule } from './layout/register/register.module';
import { BuscarJogadoresModule } from './layout/buscar-jogadores/buscar-jogadores.module';
import { BuscarClansModule } from './layout/buscar-clans/buscar-clans.module';
import { ClanModule } from './layout/clan/clan.module';
import { SobreModule } from './layout/sobre/sobre.module';
import { AuthGuardLoginService } from './guards/auth-guard-login.service';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    HttpModule,
    AppRoutingModule,
    HomeModule,
    RegisterModule,
    FormsModule,
    BrowserAnimationsModule,
    LoginModule,
    NgxSpinnerModule,
    ToastrModule.forRoot(),
    HttpRequestInterceptorModule,
    BuscarJogadoresModule,
    BuscarClansModule,
    ClanModule,
    SobreModule,
    MenuLayoutModule
  ],
  providers: [
    AuthGuardService,
    AuthGuardService.guards,
    AuthGuardLoginService,
    AuthGuardLoginService.guards
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
