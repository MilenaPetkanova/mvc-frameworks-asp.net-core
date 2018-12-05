namespace Eventure.Models.Events
{
    using System;
    using System.Collections.Generic;

    public class Event
    {
        public Event()
        {
            this.Orders = new List<Order>();
        }

        public string Id { get; set; }

        public string UUID { get; set; }

        public string Name { get; set; }

        public string Place { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public int TotalTickets { get; set; }

        public decimal PricePerTicket { get; set; }

        public IList<Order> Orders { get; set; }
    }
}
