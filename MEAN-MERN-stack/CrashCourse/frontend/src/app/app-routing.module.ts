import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PostCreateComponent } from './components/postComponents/post-create/post-create.component';
import { PostListComponent } from './components/postComponents/post-list/post-list.component';
import { AuthGaurd } from './components/auth/auth.guard';

const routes: Routes = [
  { path: '', redirectTo: 'list', pathMatch: 'full' },
  { path: 'create', component: PostCreateComponent, canActivate: [AuthGaurd] },
  { path: 'edit/:postId', component: PostCreateComponent, canActivate: [AuthGaurd] },
  { path: 'list', component: PostListComponent},
  { path: 'auth', loadChildren: './components/auth/auth.module#AuthModule'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
  providers: [AuthGaurd]
})
export class AppRoutingModule { }
