import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  userName = 'Bruce';
  userData = {
    email: 'brucecomedordesofa@mail.com',
    role: 'Irritar o Fabio',
  }
  userPlayer = 'Skalidis';
  clube = 'Corinthians';
  estatisticas = {
    temporadas: 7,
    jogos: 423,
    gols: 674,
    assistencias: 50,
    hdj: 197
  }
  dadospokemon = {
    name: 'Charizard',
    type1: 'Fire',
    type2: 'Flying',
    abilities1: 'Blaze',
    abilities2: 'Solar Power',
    height: 1.70,
    weight: 90.5,
  }

  dadosAnimon = {
    nome: 'Metanik',
    raca: 'Humanid',
    equip: 'Espada',
    pPrincipal: 'Fogo'
  }

  title = 'AngularJS';
}
