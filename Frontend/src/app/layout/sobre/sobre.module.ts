import { RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SobreComponent } from './sobre.component';

@NgModule({
    declarations: [
        SobreComponent
    ],
    imports: [
        CommonModule,
        RouterModule
    ],
    exports: [
        SobreComponent
    ]
})
export class SobreModule { }