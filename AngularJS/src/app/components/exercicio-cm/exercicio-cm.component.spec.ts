import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ExercicioCMComponent } from './exercicio-cm.component';

describe('ExercicioCMComponent', () => {
  let component: ExercicioCMComponent;
  let fixture: ComponentFixture<ExercicioCMComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ExercicioCMComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ExercicioCMComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
