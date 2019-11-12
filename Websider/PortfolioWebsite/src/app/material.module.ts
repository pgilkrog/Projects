import { NgModule } from '@angular/core';
import { MatProgressSpinnerModule,
  MatTooltipModule,
  MatGridListModule,
  MatExpansionModule,
  MatButtonModule,
  MatFormFieldModule,
  MatCardModule,
  MatAutocompleteModule,
  MatInputModule,
  MatChipsModule,
  MatIconModule} from '@angular/material';

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
    MatProgressSpinnerModule,
    MatChipsModule,
    MatIconModule
  ],
})

export class MaterialModule {}
