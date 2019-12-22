import { TestBed } from '@angular/core/testing';

import { AdminCinemaControlService } from './admin-cinema-control.service';

describe('AdminCinemaControlService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: AdminCinemaControlService = TestBed.get(AdminCinemaControlService);
    expect(service).toBeTruthy();
  });
});
