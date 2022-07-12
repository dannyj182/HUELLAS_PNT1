using HUELLAS_PNT1.Context;
using HUELLAS_PNT1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HUELLAS_PNT1.Controllers
{
    public class UserController : Controller
    {
        private readonly HuellasDatabaseContext _context;
        private UserManager<IdentityUser> userManager;
        public UserController(HuellasDatabaseContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            var users = await _context.Users.ToListAsync();
            var userRolesViewModel = new List<UserViewModel>();
            foreach (IdentityUser user in users)
            {
                var thisViewModel = new UserViewModel();
                thisViewModel.UserId = user.Id;
                thisViewModel.Email = user.Email;
                thisViewModel.UserName = user.UserName;
                userRolesViewModel.Add(thisViewModel);
            }
            return View(userRolesViewModel);
        }


        public async Task<ActionResult> EditAsync(string id)
        {
            IdentityUser appUser = new IdentityUser();
            var usuario = await _context.Users.FindAsync(id);
            IdentityUser user = new IdentityUser();
            user.UserName = appUser.UserName;
            user.Email = appUser.Email;

            return View(usuario);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(string id, IdentityUser model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var usuario = await _context.Users.FindAsync(id);
            usuario.NormalizedEmail = model.Email.ToUpper();
            usuario.NormalizedUserName = model.Email.ToUpper();
            usuario.Email = model.Email;
            usuario.UserName = model.Email;
          
            _context.SaveChanges();
            TempData["msg"] = "Datos de usuario cargados!";
            return RedirectToAction("Index");
        }


        // GET: User/Delete/5
        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var usuario = await _context.Users.FindAsync(id);
            _context.Users.Remove(usuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(string id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}







