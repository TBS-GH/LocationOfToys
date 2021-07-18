using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LocationOfToys.Data;
using LocationOfToys.Models;

namespace LocationOfToys.Controllers
{
    public class BoxesController : Controller
    {
        private readonly LocationOfToysContext _context;

        public BoxesController(LocationOfToysContext context)
        {
            _context = context;
        }

        // GET: Boxes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Box.ToListAsync());
        }

        // GET: Boxes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var box = await _context.Box
                .FirstOrDefaultAsync(m => m.Id == id);
            if (box == null)
            {
                return NotFound();
            }

            return View(box);
        }

        // GET: Boxes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Boxes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BoxColour,Name")] Box box)
        {
            if (ModelState.IsValid)
            {
                _context.Add(box);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(box);
        }

        // GET: Boxes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var box = await _context.Box.FindAsync(id);
            if (box == null)
            {
                return NotFound();
            }
            return View(box);
        }

        // POST: Boxes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BoxColour,Name")] Box box)
        {
            if (id != box.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(box);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BoxExists(box.Id))
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
            return View(box);
        }

        // GET: Boxes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var box = await _context.Box
                .FirstOrDefaultAsync(m => m.Id == id);
            if (box == null)
            {
                return NotFound();
            }

            return View(box);
        }

        // POST: Boxes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var box = await _context.Box.FindAsync(id);
            _context.Box.Remove(box);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BoxExists(int id)
        {
            return _context.Box.Any(e => e.Id == id);
        }
    }
}
