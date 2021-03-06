﻿using Domain.Entity.Base;
using System;

namespace Domain.Entity
{
    public class TicketEntity : EntityBase
    {
        public bool IsActive { get; set; }
        public int? PersonId { get; set; }
        public virtual PersonEntity Person { get; set; }
        public int? PlaceId { get; set; }
        public virtual PlaceEntity Place { get; set; }
        public double Price { get; set; }
        public DateTime PurchasedDate { get; set; }
        public DateTime? RevertedDate { get; set; }
        public int? SessionId { get; set; }
        public virtual SessionEntity Session { get; set; }
    }
}
