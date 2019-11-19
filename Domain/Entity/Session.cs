using Domain.Entity.Base;
using System;
using System.Collections.Generic;

namespace Domain.Entity
{
    public class SessionEntity : EntityBase
    {
        public double BaseTicketPrice { get; set; }
        public DateTime DateAndTime { get; set; }
        public virtual FilmInCinemaEntity FilmInCinema { get; set; }
        public int? FilmInCinemaId { get; set; }
        public virtual HallEntity Hall { get; set; }
        public int? HallId { get; set; }
        public ICollection<TicketEntity> Tickets { get; set; }
    }
}
