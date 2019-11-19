using Domain.Entity.Base;
using Domain.Enum;
using System.Collections.Generic;

namespace Domain.Entity
{
    public class HallEntity : EntityBase
    {
        public string Caption { get; set; }
        public CinemaEntity Cinema { get; set; }
        public int? CinemaId { get; set; }
        public ICollection<PlaceEntity> Places { get; set; }
        public ICollection<SessionEntity> Sessions{ get; set; }
        public ScreenType ScreenType { get; set; }
    }
}
