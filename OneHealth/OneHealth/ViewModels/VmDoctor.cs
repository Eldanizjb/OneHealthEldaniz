using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OneHealth.Models;

namespace OneHealth.ViewModels
{
    public class VmDoctor : VmLayout
    {
        public List<Comment> Comment { get; set; }
        public List<Contact> Contact { get; set; }
        public List<Doctor> Doctor { get; set; }
        public List<TypePosition> TypePosition { get; set; }
    }
}
