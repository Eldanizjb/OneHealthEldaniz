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
    public class News
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string MainImage { get; set; }
        [NotMapped]
        public IFormFile MainImageFile { get; set; }
        [MaxLength(500)]
        public string Title { get; set; }
        public DateTime CreateDate { get; set; }
        [ForeignKey("CustomUser")]
        public string CustomUserId { get; set; }
        public CustomUser CustomUser { get; set; }
        [ForeignKey("NewsCategory")]
        public int CategoryId { get; set; }
        public NewsCategory NewsCategory { get; set; }

        public List<TagToNews> TagToNews { get; set; }
        public List<Comment> Comment { get; set; }


    }
}
