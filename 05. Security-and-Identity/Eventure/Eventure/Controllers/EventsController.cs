namespace Eventure.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

    using Eventure.Data;
    using Eventure.Models;
    using Eventure.Models.Events;
    using AutoMapper;
    using Eventure.ViewModels.Events;
    using Microsoft.AspNetCore.Authorization;

    public class EventsController : Controller
    {
        private readonly EventureDbContext _context;
        private readonly IMapper _mapper;

        public EventsController(EventureDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return this.View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EventViewModel model)
        {
            if (ModelState.IsValid)
            {
                var eventEntity = new Event
                {
                    UUID = model.UUID,
                    Name = model.Name,
                    Start = model.Start,
                    End = model.End,
                    Place = model.Place, 
                    TotalTickets = model.TotalTickets,
                    PricePerTicket = model.PricePerTicket
                };

                _context.Events.Add(eventEntity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(AllEvents));
            }

            return this.View(model);
        }

        public async Task<IActionResult> AllEvents()
        {
            var allEvents = this._context.Events
                .Select(e => _mapper.Map<Event, EventViewModel>(e)).ToList();

            var model = new AllEventsViewModel
            {
                Events = allEvents
            };

            return this.View(model);
        }

        [Authorize]
        public async Task<IActionResult> UserEvents()
        {
            var userEvents = this._context.Orders
                .Where(o => o.Customer.UserName == this.User.Identity.Name)
                .Select(o => o.Event)
                .ToList();

            var userEventsViewModel = userEvents
                .Select(e => _mapper.Map<Event, EventViewModel>(e)).ToList();

            var model = new UserEventsViewModel
            {
                Events = userEventsViewModel
            };

            return View("~/Views/Events/UserEvents.cshtml", model);
        }
    }
}
