import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BeecrowdComponent } from './exercicios/beecrowd/beecrowd.component';
import { ParentDataComponent } from './components/parent-data/parent-data.component';
import { ExercicioCMComponent } from './components/exercicio-cm/exercicio-cm.component';
import { ExercicioPKMComponent } from './components/exercicio-pkm/exercicio-pkm.component';
import { ExercicioAnimonComponent } from './components/exercicio-animon/exercicio-animon.component';

@NgModule({
  declarations: [
    AppComponent,
    BeecrowdComponent,
    ParentDataComponent,
    ExercicioCMComponent,
    ExercicioPKMComponent,
    ExercicioAnimonComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {
  exibirBeecrowdFlag = false;

  exibirBeecrowd() {
    this.exibirBeecrowdFlag = true;
  }

 }
