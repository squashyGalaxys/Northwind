using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesOvning
{
    public class Bil : IComparable
    {
        private string tillverkare;
        private int år;

        public Bil(string tillverkare, int år)
        {
            this.tillverkare = tillverkare;
            this.år = år;
        }

        public int År
        {
            get { return år; }
            set { år = value; }
        }

        public string Tillverkare
        {
            get { return tillverkare; }
            set { tillverkare = value; }
        }
        //Kapslade klasser
        //En klass som sorterar efter år i stigande ordning
        private class SortÅrStigande : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Bil c1 = (Bil)a;
                Bil c2 = (Bil)b;
                if (c1.år > c2.år)
                    return 1;
                if (c1.år < c2.år)
                    return -1;
                else
                    return 0;
            }
        }
        //En klass som sorterar efter år i fallande ordning
        private class SortÅrFallande : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Bil c1 = (Bil)a;
                Bil c2 = (Bil)b;
                if (c1.år < c2.år)
                    return 1;
                if (c1.år > c2.år)
                    return -1;
                else
                    return 0;
            }
        }
        //En klass som sorterar efter tillverkare i fallande ordning
        private class SortTillverkareFallande : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Bil c1 = (Bil)a;
                Bil c2 = (Bil)b;
                return string.Compare(c2.tillverkare, c1.tillverkare);
            }

        }
        //Implementerar IComparable CompareTo för att sortera efter tillverkare i stigande ordning
        int IComparable.CompareTo(object? obj)
        {
            Bil c = (Bil)obj;
            return string.Compare(this.tillverkare, c.tillverkare);
        }

        //En method som returnerar ett IComparer objekt för sortering
        public static IComparer sortYearAscending()
        {
            return new SortÅrStigande();
        }
        //En metod som returnerar ett IComparer objekt för sortering
        public static IComparer sortYearDescending()
        {
            return new SortÅrFallande();
        }
        //En metod som returnerar ett IComparer objekt för sortering
        public static IComparer sortMakeDescending()
        {
            return new SortTillverkareFallande();
        }

    }
}
