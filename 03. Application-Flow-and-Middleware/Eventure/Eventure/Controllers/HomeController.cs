namespace Eventure.Controllers
{
    using System.Diagnostics;
    using Microsoft.AspNetCore.Mvc;
    using AutoMapper;

    using Eventure.Models;
    using Eventure.Data;
    using Microsoft.AspNetCore.Authorization;

    public class HomeController : Controller
    {
        private readonly EventureDbContext db;
        private readonly IMapper mapper;

        public HomeController(EventureDbContext chuskaDbContext, IMapper mapper)
        {
            this.db = chuskaDbContext;
            this.mapper = mapper;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
