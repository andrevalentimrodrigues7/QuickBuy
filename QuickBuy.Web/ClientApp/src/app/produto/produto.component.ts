import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-produto',
  //templateUrl: './produto.component.html'
  template: '<html><body>{{ obterNome() }}</body></html>'
})
export class ProdutoComponent implements OnInit {

  public idProduto: number;
  public nome: string;
  public descricao: string;
  public valor: number;
  public liberado: boolean;

  constructor() { }

  public obterNome(): string {
    return "Teste";
  }

  ngOnInit() {
  }

}
