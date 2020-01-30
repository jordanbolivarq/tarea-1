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
            Console.Write("Ingrese cateto y:");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Ingrese cateto z:");
            double z = double.Parse(Console.ReadLine());
            double b = 90;
            
            double sumaCuadrados = (Math.Pow(z, 2) + Math.Pow(y, 2));
            double t = Math.Sqrt(sumaCuadrados);

            double cRadianes = Math.Asin((z / t));
            
            double c = cRadianes * (180 / Math.PI);

            double a = 180 - c - b;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("t = " + t);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);
        }
    }
}
