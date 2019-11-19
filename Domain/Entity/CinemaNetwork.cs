using Domain.Entity.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    public class CinemaNetworkEntity : EntityBase
    {
        public ICollection<CinemaEntity> Cinemas { get; set; }
        public string WebSite { get; set; }
    }
}
