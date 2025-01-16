using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExemple
{
    public class GenericExample
    {
        public static void PrintElements<T>(T[] elements)
        {
            foreach (T element in elements)
            {
                Console.WriteLine(element);
            }
        }
    }
}
