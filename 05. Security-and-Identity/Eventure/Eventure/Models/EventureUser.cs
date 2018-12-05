namespace Eventure.Models
{
    using Eventure.Models.Enums;
    using Eventure.Models.Events;
    using Microsoft.AspNetCore.Identity;
    using System.Collections.Generic;

    public class EventureUser : IdentityUser
    {
        public EventureUser()
        {
            this.Orders = new List<Order>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UCN { get; set; }

        public RoleType Role { get; set; }

        public IList<Order> Orders { get; set; }
    }
}
