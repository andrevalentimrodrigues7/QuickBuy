import { Component, OnInit } from '@angular/core';
import { Usuario } from '../../model/usuario';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  public usuario;


  constructor(private route: Router) {
    this.usuario = new Usuario();
  }

  entrar() {
    if (this.usuario.email == "andrevalentimrodrigues7@gmail.com" && this.usuario.senha == "12345") {
      sessionStorage.setItem("usuario-autenticado", "1");
      alert("Usuário Autenticado");
      this.route.navigate(['/'])
    }
  }


  ngOnInit() {
  }

}
