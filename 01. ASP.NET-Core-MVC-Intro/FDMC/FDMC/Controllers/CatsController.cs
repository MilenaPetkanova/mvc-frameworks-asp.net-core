using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FDMC.Models;

namespace FDMC.Controllers
{
    public class CatsController : Controller
    {
        private readonly FDMCContext _context;

        public CatsController(FDMCContext context)
        {
            _context = context;
        }

        [HttpGet("/")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cat.ToListAsync());
        }

        [HttpGet("/cats/{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cat = await _context.Cat
                .SingleOrDefaultAsync(m => m.Id == id);
            if (cat == null)
            {
                return NotFound();
            }

            return View(cat);
        }

        [HttpGet("/cats/add")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("cats/add")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Age,Breed,imageUrls")] Cat cat)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cat);
        }

        [HttpGet("/cats/edit/{id}")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cat = await _context.Cat.SingleOrDefaultAsync(m => m.Id == id);
            if (cat == null)
            {
                return NotFound();
            }
            return View(cat);
        }

        [HttpPost("/cats/edit/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Age,Breed,imageUrls")] Cat cat)
        {
            if (id != cat.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CatExists(cat.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cat);
        }

        [HttpGet("cats/detele/{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cat = await _context.Cat
                .SingleOrDefaultAsync(m => m.Id == id);
            if (cat == null)
            {
                return NotFound();
            }

            return View(cat);
        }

        // POST: Cats/Delete/5
        [HttpPost("cats/detele/{id}"), ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cat = await _context.Cat.SingleOrDefaultAsync(m => m.Id == id);
            _context.Cat.Remove(cat);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CatExists(int id)
        {
            return _context.Cat.Any(e => e.Id == id);
        }
    }
}
