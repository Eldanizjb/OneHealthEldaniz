using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OneHealth.Data;
using OneHealth.Models;
using OneHealth.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OneHealth.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            VmHome model = new VmHome
            {
                Doctor = _context.Doctor.Include("Contact").ToList(),
                News = _context.News.Include("CustomUser").Include("NewsCategory").Include(tn => tn.TagToNews)
                                     .ThenInclude(t => t.Tag).ToList(),
                Comment = _context.Comment.Include("TypePosition").ToList(),

            };

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

      
    }
}
