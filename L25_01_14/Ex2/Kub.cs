using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class Kub : gKroppar
    {
        public double sida;
        public Kub(double s)
        {
            sida = s;
        }
        public override double Area
        {
            get { return 6 * sida * sida; }
            set { sida = Math.Sqrt(value / 6); }
        }
    }
}
