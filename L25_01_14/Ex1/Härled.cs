using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class Härled : BasKlass
    {
        public Härled()
        {
            Console.WriteLine("Konstruktör av en härledd klass");
        }
        public new void Utskrift()
        {
            Console.WriteLine("Jag är en härledd klass");
        }
    }

}
