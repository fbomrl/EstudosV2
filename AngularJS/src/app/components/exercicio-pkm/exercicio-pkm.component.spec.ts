import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ExercicioPKMComponent } from './exercicio-pkm.component';

describe('ExercicioPKMComponent', () => {
  let component: ExercicioPKMComponent;
  let fixture: ComponentFixture<ExercicioPKMComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ExercicioPKMComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ExercicioPKMComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
