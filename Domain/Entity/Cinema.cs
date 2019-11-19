using Domain.Entity.Base;
using Domain.Enum;
using System.Collections.Generic;

namespace Domain.Entity
{
    public class CinemaEntity : EntityBase
    {
        public string Address { get; set; }
        public string Caption { get; set; }
        public virtual CinemaNetworkEntity CinemaNetwork { get; set; }
        public int? CinemaNetworkId { get; set; }
        public City City { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public ICollection<FilmInCinemaEntity> FilmInCinemas { get; set; }
        public ICollection<HallEntity> Halls { get; set; }
        public string PhoneNumber { get; set; }
    }
}
