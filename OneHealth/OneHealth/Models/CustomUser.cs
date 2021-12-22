using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace OneHealth.Models
{
    public class CustomUser : IdentityUser
    {
        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Surname { get; set; }
        [MaxLength(250)]
        public string Address { get; set; }
        [MaxLength(30)]
        public string Phone { get; set; }
        public DateTime CreateDate { get; set; }
        public List<News> News { get; set; }
        public string RoleId { get; set; }



    }
}
