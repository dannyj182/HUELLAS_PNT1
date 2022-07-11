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
    }
}
