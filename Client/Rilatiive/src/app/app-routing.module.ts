import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutComponent } from './components/about/about.component';
import { ContactUsFormComponent } from './components/contact-us-form/contact-us-form.component';
import { HomeComponent } from './components/home/home.component';
import { PrivateAreaComponent } from './components/private-area/private-area.component';
import { RealTimeComponent } from './components/real-time/real-time.component';
import { SearchComponent } from './components/search/search.component';
import { SignInComponent } from './components/sign-in/sign-in.component';
import { SignUpComponent } from './components/sign-up/sign-up.component';


const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'Home',component:HomeComponent},
  { path: 'About', component:AboutComponent},
  { path: 'SignUp',component:SignUpComponent},
  { path: 'SignIn',component:SignInComponent},
  { path: 'Real',component:RealTimeComponent},
  { path: 'Contact',component:ContactUsFormComponent},
  { path: 'Area',component:PrivateAreaComponent},
  { path: 'Search',component:SearchComponent},




  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
