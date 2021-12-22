using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OneHealth.Data;
using OneHealth.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace OneHealth.Controllers
{
    public class DoctorController : Controller
    {
        private readonly AppDbContext _context;

        public DoctorController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            VmDoctor model = new VmDoctor
            {
                Doctor = _context.Doctor.Include("Contact").ToList(),
                Comment = _context.Comment.Include("TypePosition").ToList(),
            };

            return View(model);
        }
    }
}
