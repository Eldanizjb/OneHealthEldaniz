using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OneHealth.Models;

namespace OneHealth.ViewModels
{
    public class VmLayout
    {
        public List<Aplication> Aplication { get; set; }
        public Setting Setting { get; set; }
        public List<Partner> Partner { get; set; }
        public List<Sosial> Sosial { get; set; }

    }
}
