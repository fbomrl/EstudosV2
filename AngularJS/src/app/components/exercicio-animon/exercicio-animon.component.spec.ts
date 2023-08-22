import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ExercicioAnimonComponent } from './exercicio-animon.component';

describe('ExercicioAnimonComponent', () => {
  let component: ExercicioAnimonComponent;
  let fixture: ComponentFixture<ExercicioAnimonComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ExercicioAnimonComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ExercicioAnimonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
