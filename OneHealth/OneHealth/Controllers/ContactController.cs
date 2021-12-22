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
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            VmContact model = new VmContact
            {
                Comment = _context.Comment.Include("TypePosition").ToList(),
            };

            return View(model);
        }
    }
}
