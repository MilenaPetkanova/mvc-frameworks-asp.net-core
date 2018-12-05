namespace Eventure.Controllers
{
    using System;
    using System.Linq;
    using AutoMapper;
    using Eventure.Data;
    using Eventure.Models;
    using Eventure.ViewModels.Orders;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class OrdersController : Controller
    {
        private readonly EventureDbContext _context;
        private readonly IMapper _mapper;

        public OrdersController(EventureDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        [Authorize]
        public IActionResult Create(string eventId, int ticketsCount)
        {
            var user = this._context.Users
                .FirstOrDefault(u => u.UserName == this.User.Identity.Name);

            var order = new Order
            {
                EventId = eventId,
                CustomerId = user.Id,
                OrderedOn = DateTime.Now,
                TicketsCount = ticketsCount
            };

            this._context.Orders.Add(order);
            this._context.SaveChanges();

            return this.RedirectToAction("UserEvents", "Events");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult All()
        {
            var model = this._context.Orders.Select(o => new AllOrdersViewModel
            {
                CustomerName = o.Customer.UserName,
                EventName = o.Event.Name,
                OrderedOn = o.OrderedOn
            })
            .ToList();

            //var allOrders = this._context.Orders;

            //var allOrdersViewModel = allOrders
            //    .Select(o => _mapper.Map<Order, OrderViewModel>(o)).ToList();

            //var model = new AllOrdersViewModel
            //{
            //    AllOrders = allOrdersViewModel
            //};

            return View(model);
        }
    }
}