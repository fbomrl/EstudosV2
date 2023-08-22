import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-exercicio-cm',
  templateUrl: './exercicio-cm.component.html',
  styleUrls: ['./exercicio-cm.component.scss']
})
export class ExercicioCMComponent implements OnInit {
  @Input() namePlayer!: string;
  @Input() clube!: string;
  @Input() estatisticas!: {temporadas: number, jogos: number, gols: number, assistencias: number, hdj: number};


  constructor() { }

  ngOnInit(): void {
  }

}
