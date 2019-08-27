import { Component, OnInit } from '@angular/core';
import { Usuario } from '../../model/usuario';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  public usuario;


  constructor() {
    this.usuario = new Usuario();
  }

  entrar() {
    
  }


  ngOnInit() {
  }


}
