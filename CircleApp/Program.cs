using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle aCircle = new Circle();
            Console.Write(@"Enter a Radious : ");
            aCircle.radious = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nYour Diameter is : " + aCircle.GetDiameter());
            Console.WriteLine(@"Your Perimeter is : " + aCircle.GetPerimeter());
            Console.WriteLine(@"Your Area is : " + aCircle.GetArea());

            Console.ReadKey();
        }
    }
}
