using Business.EntityService.Interface;
using Data.UnitOfWork.Interface;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.EntityService
{
    public class FilmService : IFilmService
    {
        private IUnitOfWork unitOfWork;

        public FilmService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Add(string caption, int duration, int ageRate, DateTime premiere)
        {
            FilmEntity filmEntity = new FilmEntity
            {
                Caption = caption,
                Duration = duration,
                AgeRate = ageRate,
                PremiereDate = premiere
            };
        }

        public void Update(int id, string caption, int duration, int ageRate, DateTime premiere)
        {
            throw new NotImplementedException();
        }
    }
}
