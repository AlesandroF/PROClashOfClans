import { RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BuscarClansComponent } from './buscar-clans.component';

@NgModule({
    declarations: [
        BuscarClansComponent
    ],
    imports: [
        CommonModule,
        RouterModule
    ],
    exports: [
        BuscarClansComponent
    ]
})
export class BuscarClansModule { }