import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutComponent } from './components/about/about.component';
import { HomeComponent } from './components/home/home.component';
import { RealTimeComponent } from './components/real-time/real-time.component';
import { SignInComponent } from './components/sign-in/sign-in.component';
import { SignUpComponent } from './components/sign-up/sign-up.component';


const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'Home',component:HomeComponent},
  { path: 'About', component:AboutComponent},
  { path: 'SignUp',component:SignUpComponent},
  { path: 'SignIn',component:SignInComponent},
  { path: 'Real',component:RealTimeComponent},



  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
