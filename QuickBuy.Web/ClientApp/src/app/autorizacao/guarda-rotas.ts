import { Injectable } from '@angular/core';
import { CanActivate, Router, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class GuardaRotas implements CanActivate {

  constructor(private route: Router) {

  }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {

    var usuarioAutenticado = sessionStorage.getItem("usuario-autenticado")
    if (usuarioAutenticado == "1") {
      return true;
    }

    this.route.navigate(['/entrar'], { queryParams: { returnUrl: state.url } });
    return false;

  }

}
