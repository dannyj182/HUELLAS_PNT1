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
    public class InteresadoController : Controller
    {
        private readonly HuellasDatabaseContext _context;

        public InteresadoController(HuellasDatabaseContext context)
        {
            _context = context;
        }

        // GET: Interesado
        public async Task<IActionResult> Index()
        {
            return View(await _context.Adopters.ToListAsync());
        }

        // GET: Interesado/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interesado = await _context.Adopters
                .FirstOrDefaultAsync(m => m.Id == id);
            if (interesado == null)
            {
                return NotFound();
            }

            return View(interesado);
        }

        // GET: Interesado/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Interesado/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NombreCompleto,Telefono,Email,MascotaDeInteres")] Interesado interesado)
        {
            if (ModelState.IsValid)
            {
                _context.Add(interesado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(interesado);
        }

        // GET: Interesado/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interesado = await _context.Adopters.FindAsync(id);
            if (interesado == null)
            {
                return NotFound();
            }
            return View(interesado);
        }

        // POST: Interesado/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NombreCompleto,Telefono,Email,MascotaDeInteres")] Interesado interesado)
        {
            if (id != interesado.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(interesado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InteresadoExists(interesado.Id))
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
            return View(interesado);
        }

        // GET: Interesado/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interesado = await _context.Adopters
                .FirstOrDefaultAsync(m => m.Id == id);
            if (interesado == null)
            {
                return NotFound();
            }

            return View(interesado);
        }

        // POST: Interesado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var interesado = await _context.Adopters.FindAsync(id);
            _context.Adopters.Remove(interesado);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InteresadoExists(int id)
        {
            return _context.Adopters.Any(e => e.Id == id);
        }
    }
}
