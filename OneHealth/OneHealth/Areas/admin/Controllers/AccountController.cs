using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OneHealth.Data;
using OneHealth.Models;
using OneHealth.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneHealth.Areas.admin.Controllers
{
    [Area("admin")]
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController (AppDbContext context, SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            _signInManager = signInManager;
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>  Login(VmLogin model)
        {
            CustomUser user =_context.CustomUser.FirstOrDefault(u=>u.UserName==model.UserName);
            if (user!=null)
            {
                var result =await _signInManager.PasswordSignInAsync(user, model.Password, false, false);

                if (result.Succeeded) 
                {
                    return RedirectToAction("Index", "Home");
                } 
            }
            return View();
        }
    }
}
