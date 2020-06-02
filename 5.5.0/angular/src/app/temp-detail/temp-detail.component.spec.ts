import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TempDetailComponent } from './temp-detail.component';

describe('TempDetailComponent', () => {
  let component: TempDetailComponent;
  let fixture: ComponentFixture<TempDetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TempDetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TempDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
