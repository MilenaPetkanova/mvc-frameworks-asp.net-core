﻿namespace Eventure.Models
{
    using Eventure.Models.Events;
    using System;

    public class Order
    {
        public string Id { get; set; }

        public DateTime OrderedOn { get; set; }

        public string EventId { get; set; }
        public Event Event { get; set; }

        public string CustomerId { get; set; }
        public EventureUser Customer { get; set; }

        public int TicketsCount { get; set; }
    }
}
