import { Injectable,Inject} from "@angular/core";
import {HttpClient,HttpHeaders } from "@angular/common/http";
import {Observable} from "rxjs";
import { Lanches } from "../../model/lanches/model.lanches";


@Injectable({
  providedIn: 'root'
})

//com o @Injectable ele permite usar objetos o variaveis de qualquer lugar do projeto
// tm colocar no  providers: [UsuariosServicos], em app.module.ts

export class LanchesServicos {

  private baseUrl: string;

  public erros: string;

  constructor(private http: HttpClient,@Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  public getLanches(): Observable<Lanches[]> {
    return this.http.get<Lanches[]>(this.baseUrl + "api/Lanches")
  }
    
}
