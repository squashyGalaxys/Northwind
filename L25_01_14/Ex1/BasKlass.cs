using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class BasKlass
    {
        string strängBasKlass;
        public BasKlass()
        {
            Console.WriteLine("Basklass konstruktor");
        }
        public BasKlass(string minSträng)
        {
            strängBasKlass = minSträng;
            Console.WriteLine(strängBasKlass);
        }

        public void Utskrift()
        {
            Console.WriteLine("Jag är en basklass");
        }
    }
}
