using Microsoft.AspNetCore.Mvc;
using OneHealth.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OneHealth.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace OneHealth.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            VmAbout model = new VmAbout
            {
                Doctor = _context.Doctor.Include("Contact").ToList(),
                Setting = _context.Setting.FirstOrDefault()
            };

            return View(model);
        }
    }
}
