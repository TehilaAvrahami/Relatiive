import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SignUpComponent } from './components/sign-up/sign-up.component';
import { ReactiveFormsModule } from '@angular/forms';
import { SignInComponent } from './components/sign-in/sign-in.component';
import { HomeComponent } from './components/home/home.component';
import { NavComponent } from './components/nav/nav.component';
import { UserComponent } from './components/user/user.component';
import { RealTimeComponent } from './components/real-time/real-time.component';
import { AboutComponent } from './components/about/about.component';
import { ContactUsFormComponent } from './components/contact-us-form/contact-us-form.component';
import { FooterComponent } from './components/footer/footer.component';


@NgModule({
  declarations: [
    AppComponent,
    SignUpComponent,
    SignInComponent,
    HomeComponent,
    NavComponent,
    UserComponent,
    RealTimeComponent,
    AboutComponent,
    ContactUsFormComponent,
    FooterComponent,
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
