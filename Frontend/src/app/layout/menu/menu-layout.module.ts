import { RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MenuLayoutComponent } from './menu-layout.component';

@NgModule({
  declarations: [
    MenuLayoutComponent
  ],
  imports: [
    CommonModule,
    RouterModule
  ],
  exports: [
    MenuLayoutComponent
  ]
})
export class MenuLayoutModule { }
