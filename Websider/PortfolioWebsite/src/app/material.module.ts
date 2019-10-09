import { NgModule } from '@angular/core';
import { MatProgressSpinnerModule,
  MatTooltipModule,
  MatGridListModule,
  MatExpansionModule,
  MatButtonModule,
  MatFormFieldModule,
  MatCardModule,
  MatAutocompleteModule,
  MatInputModule } from '@angular/material';

@NgModule({
  exports: [
    MatTooltipModule,
    MatExpansionModule,
    MatButtonModule,
    MatFormFieldModule,
    MatCardModule,
    MatInputModule,
    MatAutocompleteModule,
    MatGridListModule,
    MatProgressSpinnerModule
  ],
})

export class MaterialModule {}
