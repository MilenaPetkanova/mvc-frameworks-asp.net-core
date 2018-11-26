namespace Eventure.Models.Events
{
    using System;

    public class Event
    {
        public int Id { get; set; }

        public string UUID { get; set; }

        public string Name { get; set; }

        public string Place { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public int TotalTickets { get; set; }

        public decimal PricePerTicket { get; set; }

        // no relaitonship between users and event is required
    }
}
