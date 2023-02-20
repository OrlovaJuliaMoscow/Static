using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r=Convert.ToDouble(Console.ReadLine());
            double square = Circle.GetSquare(r);
            double length = Circle.GetLength(r);
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double g = Circle.GetGipot(x, y);
            Console.WriteLine($"{ square} \n{length}");
            Console.ReadKey();
                         
            if (g <=r)
            {
                Console.WriteLine("Точка лежит в круге");
                
            }
            else
            {
                Console.WriteLine("Точка не лежит в круге");
            }
            Console.ReadKey();
        }
    }
}
