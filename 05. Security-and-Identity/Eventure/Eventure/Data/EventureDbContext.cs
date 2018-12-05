namespace Eventure.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Eventure.Models.Events;
    using Eventure.Models;

    public class EventureDbContext : IdentityDbContext<EventureUser, IdentityRole, string>
    {
        public EventureDbContext(DbContextOptions<EventureDbContext> options)
            : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Order> Orders { get; set; }
    }

}
