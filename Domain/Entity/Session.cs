using Domain.Entity.Base;
using System;
using System.Collections.Generic;

namespace Domain.Entity
{
    public class SessionEntity : EntityBase
    {
        public decimal BaseTicketPrice { get; set; }
        public DateTime DateAndTime { get; set; }
        public FilmInCinemaEntity FilmInCinema { get; set; }
        public int? FilmInCinemaId { get; set; }
        public HallEntity Hall { get; set; }
        public int? HallId { get; set; }
        public ICollection<TicketEntity> Tickets { get; set; }
    }
}
