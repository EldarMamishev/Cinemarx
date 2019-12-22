using Domain.Entity.Base;
using System.Collections.Generic;

namespace Domain.Entity
{
    public class CinemaNetworkEntity : EntityBase
    {
        public ICollection<CinemaEntity> Cinemas { get; set; }
        public string WebSite { get; set; }
    }
}
