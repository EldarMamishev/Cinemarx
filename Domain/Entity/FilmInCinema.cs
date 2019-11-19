using Domain.Entity.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    public class FilmInCinemaEntity : EntityBase
    {
        public virtual CinemaEntity Cinema { get; set; }
        public int? CinemaId { get; set; }
        public DateTime DateOfStart { get; set; }
        public DateTime DateOfEnd { get; set; }
        public virtual FilmEntity Film { get; set; }
        public int? FilmId { get; set; }
        public ICollection<SessionEntity> Sessions { get; set; }
    }
}
