import { Component, Inject, Input, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Lanches } from "../model/lanches/model.lanches";
import { LanchesServicos } from "../servicos/lanches/lanches.servicos";
import { Ingredientes } from "../model/ingredientes/model.ingredientes";
import { IngredientesServicos } from "../servicos/ingredientes/ingredientes.servicos";

@Component({
  selector: 'app-teste',
  templateUrl: './teste.component.html',
})

export class TesteComponent implements OnInit {
    public alface:     number = 0;
    public alfaceDesconto:     number = 0;
    public baccon:     number = 0;
    public humburguer: number = 0;
    public ovo:        number = 0;
    public queijo:     number = 0;
    public ingredientes: Ingredientes[];
    public lanches: Lanches[];

    constructor(
      private lanchesServ: LanchesServicos,
      private ingredientesServ: IngredientesServicos,
      http: HttpClient, @Inject('BASE_URL') baseUrl: string) {

        ingredientesServ.getIngredientes().subscribe(result => {
          this.ingredientes = result;
        }, error => console.error(error));
    
    
        this.lanchesServ.getLanches().subscribe(result => {
          this.lanches = result;
        }, error => console.error(error));
    }
    public desconto:number = 0.00;
    public total:number = 0.00;
    public soma: number = 0.00;
    public valorTotal: number = 0.00;
  

    ngOnInit(): void {

      }

    Adicionar(item: Ingredientes) {
      item.quantidade++;
      //-----------alface
      if (item.tipo == '1') {
      
        this.alface++;
        if ((this.alface >= 1) && (this.baccon === 0)) {
        
          this.valorTotal += item.valor;
          this.alfaceDesconto += item.valor * 0.10;
          this.desconto += item.valor * 0.10;
          this.valorTotal -= item.valor * 0.10;
        } else {
       
          this.desconto = this.desconto - this.alfaceDesconto;
          this.valorTotal = this.valorTotal - this.alfaceDesconto;
          this.alfaceDesconto = 0.00;
          this.valorTotal += item.valor;
       
        }
      }
      //-----------baccon
      else if (item.tipo == '2') {
        this.baccon++;
        this.desconto = this.desconto - this.alfaceDesconto;
        this.valorTotal = this.valorTotal + this.alfaceDesconto;
        this.alfaceDesconto = 0.00;
        this.valorTotal += item.valor;
      
      }
      //-----------humburguer
      else if (item.tipo == '3') {
        this.humburguer++;
      
        if ((this.humburguer > 0) && (item.quantidade % 3 == 0)) {
          this.desconto   += item.valor;
          this.valorTotal += item.valor;
          this.valorTotal -= item.valor;
        } else {
          this.valorTotal += item.valor;
        }
      }
      //-----------ovo
      else if (item.tipo == '4') {
        this.ovo++;
      
        this.valorTotal += item.valor;
      
      }
       //-----------queijo
      else if (item.tipo == '5') {
        this.queijo++;
      
        if ((this.queijo >= 3) && (item.quantidade % 3 == 0)) {
          this.desconto += item.valor;
          this.valorTotal += item.valor;
          this.valorTotal -= item.valor;

        } else {this.valorTotal += item.valor;}
      }
      
    }

    Remover(item: Ingredientes) {

      if (item.quantidade > 0) {

          if ((item.tipo == '2') && (this.baccon>0)) {
            this.baccon--;
            this.valorTotal -= item.valor;
        }

        if ((item.tipo == '4')) {
          this.ovo--;
          this.valorTotal -= item.valor;
        }
      
        if (((item.tipo == '5') || (item.tipo == '3')) && (item.quantidade > 0)) {
          if ((item.quantidade % 3 != 0)) {
            this.valorTotal -= item.valor
            
          } else {
            this.desconto -= item.valor;
          }
            
          }

        if ((item.tipo == '1')) {
          this.alface--;
          if (this.baccon > 0) {
            this.valorTotal -= item.valor ;
          } else {
            this.desconto -= item.valor * 0.10;
            this.alfaceDesconto -= item.valor * 0.10;
            this.valorTotal = (this.valorTotal - (item.valor - (item.valor * 0.10)));
          }

        }
     
        item.quantidade--;

        if (item.quantidade < 0) {
          item.quantidade = 0;
        }
        if (this.valorTotal <= 0) {
          this.valorTotal = 0.00;
        }

        if (item.tipo == null) {
          this.valorTotal -= item.valor
        }
      }
   
  }

  AdicionarLanches(item: Lanches) {

    if ((item.lanche == 'X-Egg Bacon') || (item.lanche == 'X-Bacon')) {
      this.baccon++;
      this.valorTotal += item.valor
    } else {
      this.valorTotal += item.valor
    }

  }


}





