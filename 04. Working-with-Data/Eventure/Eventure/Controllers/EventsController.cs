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

    public class EventsController : Controller
    {
        private readonly EventureDbContext _context;
        private readonly IMapper _mapper;

        public EventsController(EventureDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IActionResult> AllEvents()
        {
            //return View(await _context.Events.ToListAsync());
            var allEvents = this._context.Events.Select(e => _mapper.Map<Event, EventViewModel>(e)).ToList();

            var model = new AllEventsViewModel
            {
                AllEvents = allEvents
            };

            return View("~/Views/Events/AllEvents.cshtml", model);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Events
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }

        public IActionResult Create()
        {
            return View();
        }

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

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Events.FindAsync(id);
            if (@event == null)
            {
                return NotFound();
            }
            return View(@event);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UUID,Name,Place,Start,End,TotalTickets,PricePerTicket")] Event @event)
        {
            if (id != @event.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@event);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventExists(@event.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(AllEvents));
            }
            return View(@event);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Events
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @event = await _context.Events.FindAsync(id);
            _context.Events.Remove(@event);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(AllEvents));
        }

        private bool EventExists(int id)
        {
            return _context.Events.Any(e => e.Id == id);
        }
    }
}
