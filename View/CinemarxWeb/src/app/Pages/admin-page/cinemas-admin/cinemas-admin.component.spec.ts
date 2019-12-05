import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CinemasAdminComponent } from './cinemas-admin.component';

describe('CinemasAdminComponent', () => {
  let component: CinemasAdminComponent;
  let fixture: ComponentFixture<CinemasAdminComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CinemasAdminComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CinemasAdminComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
