import { RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BuscarJogadoresComponent } from './buscar-jogadores.component';

@NgModule({
  declarations: [
    BuscarJogadoresComponent
  ],
  imports: [
    CommonModule,
    RouterModule
  ],
  exports: [
    BuscarJogadoresComponent
  ]
})
export class BuscarJogadoresModule { }