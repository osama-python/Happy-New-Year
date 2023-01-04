import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CommonLayoutComponent } from './common-layout/common-layout.component';
import { ErrorComponent } from './error/error.component';
import { HomeComponent } from './home/home.component';
import { NewYearComponent } from './new-year/new-year.component';
import { ClickHereComponent } from './click-here/click-here.component';
import { UserService } from '../app/User-service/user.service';

@NgModule({
  declarations: [
    AppComponent,
    CommonLayoutComponent,
    ErrorComponent,
    HomeComponent,
    NewYearComponent,
    ClickHereComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [UserService],
  bootstrap: [AppComponent]
})
export class AppModule { }
