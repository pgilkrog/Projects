import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SignInComponent } from './components/sign-in/sign-in.component';
import { SignUpComponent } from './components/sign-up/sign-up.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { ForgotPasswordComponent } from './components/forgot-password/forgot-password.component';
import { VerifyEmailComponent } from './components/verify-email/verify-email.component';
import { SecureInnerPagesGuard } from './shared/guard/secure-inner-pages.guard';
import { AuthGuard } from './shared/guard/auth.guard';
import { RecipiesListComponent } from './components/recipies-list/recipies-list.component';
import { UploaderComponent } from './components/uploader/uploader.component';

const routes: Routes = [
  { path: "", redirectTo: "/sign-in", pathMatch: "full" },
  { path: "sign-in", component: SignInComponent, canActivate: [SecureInnerPagesGuard] },
  { path: "register-user", component: SignUpComponent, canActivate: [SecureInnerPagesGuard] },
  { path: "dashboard", component: DashboardComponent, canActivate: [AuthGuard] },
  { path: "forgot-password", component: ForgotPasswordComponent, canActivate: [SecureInnerPagesGuard] },
  { path: "verify-email-address", component: VerifyEmailComponent, canActivate: [SecureInnerPagesGuard] },
  { path: "recipies-list", component: RecipiesListComponent },
  { path: "uploader", component:UploaderComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
