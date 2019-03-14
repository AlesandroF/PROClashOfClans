import { RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ClanComponent } from './clan.component';

@NgModule({
    declarations: [
        ClanComponent
    ],
    imports: [
        CommonModule,
        RouterModule
    ],
    exports: [
        ClanComponent
    ]
})
export class ClanModule { }