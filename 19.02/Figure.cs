using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Figure
    {
        public static double V(double a)
        {
            return a * a * a;
        }

        public static double V(double a, double b, double c) 
        {
            return a * b * c;
        }
    }
}
