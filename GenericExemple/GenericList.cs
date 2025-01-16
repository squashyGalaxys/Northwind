using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExemple
{
    public class GenericList<T>
    {
        private T[] items;
        private int currentIndex = 0;

        public GenericList(int size)
        {
            items = new T[size];
        }

        public void Add(T item)
        {
            if (currentIndex < items.Length)
            {
                items[currentIndex] = item;
                currentIndex++;
            }

        }

        public void PrintItems()
        {
            foreach (T item in items)
            {
                if (item != null) 
                    Console.WriteLine(item);
            }
        }
    }
}
