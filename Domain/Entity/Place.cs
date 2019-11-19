using Domain.Entity.Base;
using Domain.Enum;
using System.Collections.Generic;

namespace Domain.Entity
{
    public class PlaceEntity : EntityBase
    {
        public ClassOfPlace Class { get; set; }
        public HallEntity Hall { get; set; }
        public int? HallId { get; set; }
        public int PlaceLine { get; set; }
        public int PlaceNumber { get; set; }
        public ICollection<TicketEntity> Tickets { get; set; }
    }
}
