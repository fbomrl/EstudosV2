import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BeecrowdComponent } from './beecrowd.component';

describe('BeecrowdComponent', () => {
  let component: BeecrowdComponent;
  let fixture: ComponentFixture<BeecrowdComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BeecrowdComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(BeecrowdComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
