using Domain.Entity.Base;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    public class HallEntity : EntityBase
    {
        public string Caption { get; set; }
        public CinemaEntity Cinema { get; set; }
        public int? CinemaId { get; set; }
        public ScreenType ScreenType { get; set; }
    }
}
