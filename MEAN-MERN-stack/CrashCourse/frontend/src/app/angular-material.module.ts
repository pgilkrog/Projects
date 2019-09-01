import { NgModule } from '@angular/core';
import {
  MatToolbarModule,
  MatInputModule,
  MatCardModule,
  MatButtonModule,
  MatExpansionModule,
  MatProgressSpinnerModule,
  MatPaginatorModule,
  MatDialogModule
} from '@angular/material';

@NgModule({
 exports: [
  MatToolbarModule,
  MatInputModule,
  MatCardModule,
  MatButtonModule,
  MatExpansionModule,
  MatProgressSpinnerModule,
  MatPaginatorModule,
  MatDialogModule
 ]
})
export class AngularMaterialModule {}
