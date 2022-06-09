using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HUELLAS_PNT1.Context;
using HUELLAS_PNT1.Models;

namespace HUELLAS_PNT1.Controllers
{
    public class AdopterController : Controller
    {
        private readonly HuellasDatabaseContext _context;

        public AdopterController(HuellasDatabaseContext context)
        {
            _context = context;
        }

        // GET: Adopter
        public async Task<IActionResult> Index()
        {
            return View(await _context.Adopters.ToListAsync());
        }

        // GET: Adopter/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adopter = await _context.Adopters
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adopter == null)
            {
                return NotFound();
            }

            return View(adopter);
        }

        // GET: Adopter/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Adopter/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FullName,Telephone,Email,PetOfInterest")] Adopter adopter)
        {
            if (ModelState.IsValid)
            {
                _context.Add(adopter);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(adopter);
        }

        // GET: Adopter/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adopter = await _context.Adopters.FindAsync(id);
            if (adopter == null)
            {
                return NotFound();
            }
            return View(adopter);
        }

        // POST: Adopter/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,Telephone,Email,PetOfInterest")] Adopter adopter)
        {
            if (id != adopter.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(adopter);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdopterExists(adopter.Id))
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
            return View(adopter);
        }

        // GET: Adopter/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adopter = await _context.Adopters
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adopter == null)
            {
                return NotFound();
            }

            return View(adopter);
        }

        // POST: Adopter/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var adopter = await _context.Adopters.FindAsync(id);
            _context.Adopters.Remove(adopter);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdopterExists(int id)
        {
            return _context.Adopters.Any(e => e.Id == id);
        }
    }
}
