using OneHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneHealth.ViewModels
{
    public class VmContact : VmLayout
    {
        public List<Comment> Comment { get; set; }
       
        public List<TypePosition> TypePosition { get; set; }
    }
}
