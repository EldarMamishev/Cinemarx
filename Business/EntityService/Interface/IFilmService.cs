using System;
using System.Collections.Generic;
using System.Text;

namespace Business.EntityService.Interface
{
    public interface IFilmService
    {
        void Add(string caption, int duration, int ageRate, DateTime premiere);
        void Update(int id, string caption, int duration, int ageRate, DateTime premiere);
    }
}
