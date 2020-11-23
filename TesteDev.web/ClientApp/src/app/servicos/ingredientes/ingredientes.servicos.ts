import { Injectable,Inject} from "@angular/core";
import {HttpClient,HttpHeaders } from "@angular/common/http";
import {Observable} from "rxjs";
import { Ingredientes } from "../../model/ingredientes/model.ingredientes";


@Injectable({
  providedIn: 'root'
})

//com o @Injectable ele permite usar objetos o variaveis de qualquer lugar do projeto
// tm colocar no  providers: [UsuariosServicos], em app.module.ts

export class IngredientesServicos {

  private baseUrl: string;

  public erros: string;

  constructor(private http: HttpClient,@Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  public getIngredientes(): Observable<Ingredientes[]> {
    return this.http.get<Ingredientes[]>(this.baseUrl + "api/Ingredientes")
  }

  getAllCats(): Observable<Ingredientes[]> {
    return this.http.get<Ingredientes[]>(this.baseUrl + "api/Ingredientes")
  }

  getIngrediente(Ingrediente: string): Observable<Ingredientes> {
    return this.http.get<Ingredientes>(this.baseUrl + "api/Ingredientes" + Ingrediente)
  }

  insertIngrediente(Ingrediente: Ingredientes): Observable<Ingredientes> {
    return this.http.post<Ingredientes>(this.baseUrl + "api/Ingredientes", Ingredientes)
  }

  updateIngrediente(Ingredient: Ingredientes): Observable<void> {
    return this.http.put<void>(
      this.baseUrl + "api/Ingredientes" + Ingredient.ingrediente,
      Ingredientes
    )
  }

  deleteIngrediente(Ingrediente: string) {
    return this.http.delete(this.baseUrl + "api/Ingredientes" + Ingrediente)
  }
}
