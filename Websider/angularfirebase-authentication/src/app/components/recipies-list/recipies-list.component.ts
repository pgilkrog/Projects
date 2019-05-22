import { Component, OnInit } from '@angular/core';
import { Recipe, smallRecipe } from 'src/app/shared/models/recipe.model';
import { RecipeService } from 'src/app/shared/services/recipe.service';
import { FormGroup, FormControl, Validators, FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-recipies-list',
  templateUrl: './recipies-list.component.html',
  styleUrls: ['./recipies-list.component.css']
})
export class RecipiesListComponent implements OnInit {
  recipies: Recipe[] = [];
  form: FormGroup;
  recipe: smallRecipe;

  constructor(private recipeService: RecipeService, private formbuilder: FormBuilder) { }

  ngOnInit() {
    this.recipeService.getRecipies().subscribe(data => {
      this.recipies = data.map(e => {
        return {
          id: e.payload.doc.id,
          ...e.payload.doc.data()
        } as Recipe
      })
    });

    this.form = this.formbuilder.group({
      name: ['', Validators.required],
      description: ['', Validators.required],
    });
  }

  get f() { return this.form.controls; }

  onSubmit() {
    this.create(this.recipe = {
      name: this.form.value.name,
      description: this.form.value.description
    });
  }

  create(recipe: smallRecipe) {
    this.recipeService.createRecipe(recipe);
  }

  update(recipe: Recipe) {
    this.recipeService.updateRecipe(recipe);
  }

  delete(id: string) {
    this.recipeService.deleteRecipe(id);
  }

}
