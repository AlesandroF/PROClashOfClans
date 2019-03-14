import { BuscarJogadoresComponent } from './layout/buscar-jogadores/buscar-jogadores.component';
import { RegisterComponent } from './layout/register/register.component';
import { LoginComponent } from './layout/login/login.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AuthGuardService } from './guards/auth-guard.service';
import { HomeComponent } from './home/home.component';
import { BuscarClansComponent } from './layout/buscar-clans/buscar-clans.component';
import { ClanComponent } from './layout/clan/clan.component';
import { SobreComponent } from './layout/sobre/sobre.component';
import { AuthGuardLoginService } from './guards/auth-guard-login.service';

export const routes: Routes = [
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: 'login', component: LoginComponent, canActivate: [AuthGuardLoginService] },
  { path: 'register', component: RegisterComponent, canActivate: [AuthGuardLoginService] },
  { path: 'buscar-jogadores', component: BuscarJogadoresComponent, canActivate: [AuthGuardService] },
  { path: 'buscar-clans', component: BuscarClansComponent, canActivate: [AuthGuardService] },
  { path: 'clan', component: ClanComponent, canActivate: [AuthGuardService] },
  { path: 'sobre', component: SobreComponent, canActivate: [AuthGuardService] },
  { path: 'home', component: HomeComponent, canActivate: [AuthGuardService] }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
