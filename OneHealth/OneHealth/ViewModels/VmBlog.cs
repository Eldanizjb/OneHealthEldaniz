using OneHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneHealth.ViewModels
{
    public class VmBlog : VmLayout
    {
        public List<Comment> Comment { get; set; }
        public List<Contact> Contact { get; set; }
        public List<CustomUser> CustomUser { get; set; }
        public List<Doctor> Doctor { get; set; }
        public List<Message> Message { get; set; }
        public List<News> News { get; set; }
        public List<NewsCategory> NewsCategory { get; set; }
        public List<Paraqraph> Paraqraph { get; set; }
        public List<Tag> Tag { get; set; }
        public List<TagToNews> TagToNews { get; set; }
        public List<TypePosition> TypePosition { get; set; }
    }
}
