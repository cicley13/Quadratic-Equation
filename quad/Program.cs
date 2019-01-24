using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solving a quadratic equation.");

            Console.Write("Enter a : ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b : ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter c : ");
            double c = double.Parse(Console.ReadLine());

            double x1 = (-b + Math.Sqrt((b * b) - 4 * a * c)) / 2 * a;
            double x2 = (-b - Math.Sqrt((b * b) - 4 * a * c)) / 2 * a;

            if (double.IsNaN(x1) || double.IsNaN(x2))
            {
                Console.WriteLine("imaginary roots");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("X1 is {0} /n X2 is {1}", x1, x2);
                Console.ReadLine();

            }
        }
    }
}
