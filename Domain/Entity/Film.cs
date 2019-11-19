using Domain.Entity.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    public class FilmEntity : EntityBase
    {
        public int AgeRate { get; set; }
        public string Caption { get; set; }
        public int Duration { get; set; }
        public ICollection<FilmInCinemaEntity> FilmInCinemas { get; set; }
        public DateTime PremiereDate { get; set; }
    }
}
