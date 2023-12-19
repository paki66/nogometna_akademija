using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nogometna_akademija.Abstract.Models
{
    public class Trener
    {
        public int id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string lozinka { get; set; }
        public bool aktivan { get; set; }
    }
}
