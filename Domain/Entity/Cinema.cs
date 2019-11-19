using Domain.Entity.Base;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    public class CinemaEntity : EntityBase
    {
        public string Address { get; set; }
        public string Caption { get; set; }
        public CinemaNetworkEntity CinemaNetwork { get; set; }
        public int? CinemaNetworkId { get; set; }
        public City City { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
