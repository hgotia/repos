using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BikeRentals.models;

namespace BikeRentals.Controllers
{
    public class BikesController : Controller
    {
        private readonly BikeRentalsContext _context;

        public BikesController(BikeRentalsContext context)
        {
            _context = context;
        }

        // GET: Bikes
        public async Task<IActionResult> Index()
        {
            var bikeRentalsContext = _context.Bikes.Include(b => b.BikeSizeNavigation).Include(b => b.BikeStatusNavigation);
            return View(await bikeRentalsContext.ToListAsync());
        }

        // GET: Bikes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bike = await _context.Bikes
                .Include(b => b.BikeSizeNavigation)
                .Include(b => b.BikeStatusNavigation)
                .FirstOrDefaultAsync(m => m.BikeId == id);
            if (bike == null)
            {
                return NotFound();
            }

            return View(bike);
        }

        // GET: Bikes/Create
        public IActionResult Create()
        {
            ViewData["BikeSize"] = new SelectList(_context.BikeSizes, "BikeSize1", "BikeSize1");
            ViewData["BikeStatus"] = new SelectList(_context.BikeStatuses, "BikeStats", "BikeStats");
            return View();
        }

        // POST: Bikes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BikeId,BikeStatus,BikeSize")] Bike bike)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bike);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BikeSize"] = new SelectList(_context.BikeSizes, "BikeSize1", "BikeSize1", bike.BikeSize);
            ViewData["BikeStatus"] = new SelectList(_context.BikeStatuses, "BikeStats", "BikeStats", bike.BikeStatus);
            return View(bike);
        }

        // GET: Bikes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bike = await _context.Bikes.FindAsync(id);
            if (bike == null)
            {
                return NotFound();
            }
            ViewData["BikeSize"] = new SelectList(_context.BikeSizes, "BikeSize1", "BikeSize1", bike.BikeSize);
            ViewData["BikeStatus"] = new SelectList(_context.BikeStatuses, "BikeStats", "BikeStats", bike.BikeStatus);
            return View(bike);
        }

        // POST: Bikes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BikeId,BikeStatus,BikeSize")] Bike bike)
        {
            if (id != bike.BikeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bike);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BikeExists(bike.BikeId))
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
            ViewData["BikeSize"] = new SelectList(_context.BikeSizes, "BikeSize1", "BikeSize1", bike.BikeSize);
            ViewData["BikeStatus"] = new SelectList(_context.BikeStatuses, "BikeStats", "BikeStats", bike.BikeStatus);
            return View(bike);
        }

        // GET: Bikes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bike = await _context.Bikes
                .Include(b => b.BikeSizeNavigation)
                .Include(b => b.BikeStatusNavigation)
                .FirstOrDefaultAsync(m => m.BikeId == id);
            if (bike == null)
            {
                return NotFound();
            }

            return View(bike);
        }

        // POST: Bikes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bike = await _context.Bikes.FindAsync(id);
            _context.Bikes.Remove(bike);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BikeExists(int id)
        {
            return _context.Bikes.Any(e => e.BikeId == id);
        }
    }
}
