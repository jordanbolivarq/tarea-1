using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese angulo (en grados) a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese hipotenusa t:");
            double t = double.Parse(Console.ReadLine());
            double b = 90;

            double c = 180 - a - b;

            double aRadianes = a * (Math.PI / 180);
            double bRadianes = b * (Math.PI / 180);
            double cRadianes = c * (Math.PI / 180);

            double y = (Math.Sin(aRadianes) * t) / Math.Sin(bRadianes);
            double z = (Math.Sin(cRadianes) * t) / Math.Sin(bRadianes);

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("t = " + t);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);
        }
    }
}
