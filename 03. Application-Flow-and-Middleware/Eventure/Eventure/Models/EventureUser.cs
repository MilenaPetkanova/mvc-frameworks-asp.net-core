namespace Eventure.Models
{
    using Eventure.Models.Enums;
    using Microsoft.AspNetCore.Identity;

    public class EventureUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UCN { get; set; }

        public RoleType Role { get; set; }

        // no relaitonship between users and event is required
    }
}
