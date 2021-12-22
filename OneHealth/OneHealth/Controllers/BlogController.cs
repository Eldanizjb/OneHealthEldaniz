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
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            VmBlog model = new VmBlog
            {
               
              
            };

            return View(model);
        }
    }
}
