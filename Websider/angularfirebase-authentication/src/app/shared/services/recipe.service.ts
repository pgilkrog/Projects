import { Injectable } from '@angular/core';
import { AngularFirestore } from '@angular/fire/firestore';
import { Recipe, smallRecipe } from '../models/recipe.model';

@Injectable({
  providedIn: 'root'
})
export class RecipeService {

  constructor(private firestore: AngularFirestore) { }

  getRecipies() {
    return this.firestore.collection('recipies').snapshotChanges();
  }

  createRecipe(recipe: smallRecipe) {
    return this.firestore.collection('recipies').add(recipe);
  }

  updateRecipe(recipe: Recipe) {
    delete recipe.id;
    this.firestore.doc('recipies/' + recipe.id).update(recipe);
  }

  deleteRecipe(recipeId: string) {
    this.firestore.doc('recipies/' + recipeId).delete();
  }
}
