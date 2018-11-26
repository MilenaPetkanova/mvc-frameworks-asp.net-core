namespace Eventure.Middleware.Extensions
{
    using Eventure.Data;
    using Eventure.Models;
    using Eventure.Models.Events;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public static class ApplicationBuilderExtension
    {
        public static IApplicationBuilder UseDatabaseMigration(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                serviceScope.ServiceProvider.GetRequiredService<EventureDbContext>().Database.Migrate();
                var userManager = serviceScope.ServiceProvider.GetService<UserManager<EventureUser>>();
                var roleManager = serviceScope.ServiceProvider.GetService<RoleManager<IdentityRole>>();
                var db = serviceScope.ServiceProvider.GetService<EventureDbContext>();

                CreateAdminAndUser(userManager, roleManager);
                SeedEvents(db);
            }

            return app;
        }

        private static void SeedEvents(EventureDbContext db)
        {
            if (db.Events.Count() != 0)
            {
                return;
            }

            var eventsList = new List<Event>();

            var eventEntity1 = new Event
            {
                UUID = "UUID-1",
                Name = "Test Name",
                Place = "Test Place",
                Start = new DateTime(2018, 5, 8),
                End = new DateTime(2018, 5, 8),
                TotalTickets = 28,
                PricePerTicket = 0
            };
            eventsList.Add(eventEntity1);

            var eventEntity2 = new Event
            {
                UUID = "UUID-2",
                Name = "Test Name 2",
                Place = "Test Place 2",
                Start = new DateTime(2018, 5, 8),
                End = new DateTime(2018, 5, 8),
                TotalTickets = 28,
                PricePerTicket = 100
            };
            eventsList.Add(eventEntity2);

            db.Events.AddRange(eventsList);
            db.SaveChanges();
        }

        private static void CreateAdminAndUser(UserManager<EventureUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            Task.Run(async () =>
            {
                var adminName = "Admin";
                var userName = "User";

                var adminRoleExists = await roleManager.RoleExistsAsync(adminName);
                var userRoleExists = await roleManager.RoleExistsAsync(userName);

                if (!adminRoleExists)
                {
                    await roleManager.CreateAsync(new IdentityRole
                    {
                        Name = adminName
                    });

                    var adminUser = await userManager.FindByNameAsync(adminName);

                    if (adminUser == null)
                    {
                        adminUser = new EventureUser
                        {
                            UserName = adminName,
                            Email = "admin@test.com"
                        };

                        await userManager.CreateAsync(adminUser, "test");
                        await userManager.AddToRoleAsync(adminUser, adminName);
                    }
                }

                if (!userRoleExists)
                {
                    await roleManager.CreateAsync(new IdentityRole
                    {
                        Name = userName
                    });

                    var userUser = await userManager.FindByNameAsync(userName);

                    if (userUser == null)
                    {
                        userUser = new EventureUser
                        {
                            UserName = userName,
                            Email = "user@test.com"
                        };

                        await userManager.CreateAsync(userUser, "test");
                        await userManager.AddToRoleAsync(userUser, userName);
                    }
                }
            }).Wait();
        }
    }
}

