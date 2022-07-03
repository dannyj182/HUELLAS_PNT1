using HUELLAS_PNT1.Context;
using HUELLAS_PNT1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;



namespace HUELLAS_PNT1.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly HuellasDatabaseContext _context;

        public HomeController(ILogger<HomeController> logger, HuellasDatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Nosotros()
        {
            return View();
        }

        public IActionResult BackOffice()
        {
            return View();
        }

        public async Task<IActionResult> Mascotas()
        {
            return View(await _context.Pets.ToListAsync());
        }


        public IActionResult Contacto()
        {
            var _misMascotas = new SelectList(_context.Pets.ToList(), "Id", "Nombre", null);
            ViewBag.MisMascotas = _misMascotas;
            return View();

        }

        [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create([Bind("Id,NombreCompleto,Telefono,Email,IdMascota")] Interesado interesado)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(interesado);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(interesado);
            }




        public IActionResult Privacy()
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
