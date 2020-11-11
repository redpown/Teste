import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { TesteComponent } from './teste/teste.component';
import { LanchesServicos } from './servicos/lanches/lanches.servicos';
import { IngredientesServicos } from './servicos/ingredientes/ingredientes.servicos';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    TesteComponent

  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: TesteComponent, pathMatch: 'full' }
    ])
  ],
  providers: [LanchesServicos, IngredientesServicos],
  bootstrap: [AppComponent]
})
export class AppModule { }
