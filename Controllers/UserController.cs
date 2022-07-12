using HUELLAS_PNT1.Context;
using HUELLAS_PNT1.Models;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            UserViewModel user = new UserViewModel();
            user.UserName = usuario.UserName;
            user.Email = usuario.Email;
            user.CurrentPassword = appUser.PasswordHash;

            return View(user);
        }


        [HttpPost]
        public async Task<ActionResult> Edit(string id, UserViewModel model)
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

            usuario.PasswordHash = EncodePassword(model.NewPassword);

            _context.SaveChanges();
            TempData["msg"] = "Datos de usuario cargados!";
            return RedirectToAction("Index");
        }

        public static string EncodePassword(string password)
        {
            byte[] salt;
            byte[] buffer2;
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, 0x10, 0x3e8))
            {
                salt = bytes.Salt;
                buffer2 = bytes.GetBytes(0x20);
            }
            byte[] dst = new byte[0x31];
            Buffer.BlockCopy(salt, 0, dst, 1, 0x10);
            Buffer.BlockCopy(buffer2, 0, dst, 0x11, 0x20);
            return Convert.ToBase64String(dst);
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







