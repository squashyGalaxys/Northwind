using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class Kvadrat : gKroppar
    {
        public double sida;
        public Kvadrat(double s)
        {
            sida = s;
        }
        public override double Area 
        { 
            get { return sida * sida; }
            set { sida = Math.Sqrt(value); }
        }
    }
}
