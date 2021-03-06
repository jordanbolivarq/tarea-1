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
            Console.Write("Ingrese angulo (en grados) c:");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Ingrese cateto z:");
            double z = double.Parse(Console.ReadLine());
            double b = 90;

            double a = 180 - c - b;

            double aRadianes = a * (Math.PI / 180);
            double bRadianes = b * (Math.PI / 180);
            double cRadianes = c * (Math.PI / 180);

            double y = (Math.Sin(aRadianes) * z) / Math.Sin(cRadianes);
            double sumaCuadrados = (Math.Pow(z, 2) + Math.Pow(y, 2));
            double t = Math.Sqrt(sumaCuadrados );

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("t = " + t);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);
        }
    }
}
