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
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Fullname { get; set; }
        [MaxLength(250)]
        public string Email { get; set; }
        [MaxLength(250)]
        public string Number { get; set; }
        [Column(TypeName = "ntext")]
        public string Text { get; set; }
        public DateTime CreateDate { get; set; }

        [ForeignKey("TypePosition")]
        public int TypeId { get; set; }
        public TypePosition TypePosition { get; set; }
        [ForeignKey("News")]
        public int NewsId { get; set; }
        public News News { get; set; }
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        [ForeignKey("ParentComment")]
        public int ParentCommentId { get; set; }
        public Comment ParentComment { get; set; }

    }
}
