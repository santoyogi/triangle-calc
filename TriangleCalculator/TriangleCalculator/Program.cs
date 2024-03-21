using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sideA, sideB;

            Console.Write("Enter Side A: ");
            sideA = double.Parse(Console.ReadLine());

            Console.Write("Enter Side B: ");
            sideB = double.Parse(Console.ReadLine());

            triangleStats tr = new triangleStats(sideA, sideB);

            Console.WriteLine("Hypotenuse: " + tr.GetHypotenuse());
            Console.WriteLine("Area: " + tr.GetArea());
            Console.ReadKey();
        }
    }
}

