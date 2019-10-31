import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { GalleryComponent } from './gallery/gallery.component';
import { NewPicComponent } from './new-pic/new-pic.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {
  MatCardModule,
  MatInputModule,
  MatButtonModule,
  MatTabsModule,
  MatGridListModule,
  MatListModule,
  MatProgressSpinnerModule,
  MatBottomSheetModule
 } from '@angular/material';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { BottomSheetDetailsComponent } from './bottom-sheet-details/bottom-sheet-details.component';
@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    GalleryComponent,
    NewPicComponent,
    BottomSheetDetailsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatCardModule,
    MatInputModule,
    FormsModule,
    MatButtonModule,
    HttpClientModule,
    MatTabsModule,
    MatGridListModule,
    MatListModule,
    MatProgressSpinnerModule,
    MatBottomSheetModule
  ],
  providers: [],
  bootstrap: [AppComponent],
  entryComponents: [
    BottomSheetDetailsComponent
  ]
})
export class AppModule { }
