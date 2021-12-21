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
    public class Paraqraph
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(1000)]
        public string Text { get; set; }
        [MaxLength(250)]
        public string Link { get; set; }
    }
}
