using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Number
    {
        public static double PrintMax(double num1, double num2)
        {
            if (num1 < num2) 
            {
                return num2;
            }
            else 
            {
                return num1;
            }
        }

        public static double PrintMax(double num1, double num2, double num3)
        {
            if (num1 > num2 && num1 > num3) 
            {
                return num1;
            }
            else if (num2 > num1 && num2 > num3) 
            {
                return num2;
            }
            else /*if (num3 > num1 && num3 > num2)*/
            {
                return num3;
            }
        }

        public static double PrintMax(double num1, double num2, double num3, double num4)
        {
            if (num1 > num2 && num1 > num3 && num1 > num4)
            {
                return num1;
            }
            else if (num2 > num1 && num2 > num3 && num2 > num4)
            {
                return num2;
            }
            else if (num3 > num1 && num3 > num2 && num3 > num4)
            {
                return num3;
            }
            else/* if (num4 > num1 && num4 > num2 && num4 > num3)*/
            {
                return num4;
            }
        }

        public static double PrintMax(double num1, double num2, double num3, double num4, double num5)
        {
            if (num1 > num2 && num1 > num3 && num1 > num4 && num1 > num5)
            {
                return num1;
            }
            else if (num2 > num1 && num2 > num3 && num2 > num4 && num2 > num5)
            {
                return num2;
            }
            else if (num3 > num1 && num3 > num2 && num3 > num4 && num3 > num5)
            {
                return num3;
            }
            else if (num4 > num1 && num4 > num2 && num4 > num3 && num4 > num5)
            {
                return num4;
            }
            else /*if (num5 > num1 && num5 > num2 && num5 > num3 && num5 > num4)*/
            {
                return num5;
            }
        }

        public static double Multiply(double num1, double num2)
        {
            return (num1 * num2) + 0.1;
        }
        public static uint Multiply(uint num1, uint num2)
        {
            return (num1 * num2) + 1;
        }
        public static int Multiply(int num1, int num2)
        {
            return (num1 * num2) + 2;
        }
        public static long Multiply(long num1, long num2)
        {
            return (num1 * num2) + 3;
        }
    }
}
