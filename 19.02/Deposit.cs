using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Deposit
    {
        private static string FIO;
        private static double sum;
        private static double percent = 20;

        //public Deposit(string FIO, double sum)
        //{
        //    this.FIO = FIO;
        //    this.sum = sum;
        //}

        public static double PercentSum(double sum)
        {
            return sum++;
        }

        public static Deposit operator ++(Deposit obj)
        {
            obj = sum + (percent * sum / 100);
            return obj;
        }
        public static Deposit operator --(Deposit obj)
        {
            obj =  sum - (percent * sum / 100);
            return obj;
        }
    }
}
