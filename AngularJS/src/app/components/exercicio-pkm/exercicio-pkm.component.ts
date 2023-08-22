import { Component, Input, OnInit } from '@angular/core';
import { __importDefault } from 'tslib';

@Component({
  selector: 'app-exercicio-pkm',
  templateUrl: './exercicio-pkm.component.html',
  styleUrls: ['./exercicio-pkm.component.scss']
})
export class ExercicioPKMComponent implements OnInit {

  @Input() pokemon!: {name: string, type1: string, type2: string, abilities1: string, abilities2: string
    height: number, weight: number}

  constructor() { }

  ngOnInit(): void {
  }

}
