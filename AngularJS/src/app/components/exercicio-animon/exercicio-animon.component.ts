import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-exercicio-animon',
  templateUrl: './exercicio-animon.component.html',
  styleUrls: ['./exercicio-animon.component.scss']
})
export class ExercicioAnimonComponent implements OnInit {

  @Input() animon!: {nome: string, raca: string, equip: string, pPrincipal: string}

  constructor() { }

  ngOnInit(): void {
  }

}
