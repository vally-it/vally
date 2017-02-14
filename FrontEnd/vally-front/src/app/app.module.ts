import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { MaterialModule } from '@angular/material';
import { AppComponent } from './app.component';
import { EntryListComponent } from './entry-list/entry-list.component';
import { RouterModule, Routes } from '@angular/router';

const appRoutes: Routes = [
  { path: 'entry-list', component: EntryListComponent }
];

@NgModule({
  declarations: [
    AppComponent,
    EntryListComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    MaterialModule.forRoot(),
    RouterModule.forRoot(appRoutes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})

export class AppModule { }
