using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    static class Circle
    {
        static public double GetLength(double r)
        {
            return 2*r*Math.PI;
        }
       
        static public double GetSquare(double r)
        {
            return r * r * Math.PI;
        }
        static public double GetGipot(double x, double y)
        { 
            return Math.Sqrt(x*x + y*y);
        }
    }
}
