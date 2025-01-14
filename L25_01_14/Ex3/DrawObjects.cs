using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public class DrawObject
    {
        public virtual void Draw()
        {
            Console.WriteLine("Jag är bas ritobjekt.");
        }
    }
    public class Line : DrawObject
    {
        public override void Draw()
        {
            Console.WriteLine("Jag är en linje.");
        }
    }
    public class Circle : DrawObject
    {
        public override void Draw()
        {
            Console.WriteLine("Jag är en cirkel.");
        }
    }
    public class Square : DrawObject
    {
        public override void Draw()
        {
            Console.WriteLine("Jag är en kvadrat.");
        }
    }
}
