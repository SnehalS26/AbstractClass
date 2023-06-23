using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(10);
            c1.CalculateArea();
            Console.WriteLine(c1);

            Rectangle r = new Rectangle(5 , 14);
            r.CalculateArea();
            Console.WriteLine(r);
        }
    }
}
