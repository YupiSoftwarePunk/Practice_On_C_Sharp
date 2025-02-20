using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        private string FIO;
        private double average;
        private double self;
        private string date;

        public Student(string FIO, double average, double self, string date)
        {
            this.FIO = FIO;
            this.average = average;
            this.self = self;
            this.date = date;
        }

        public static bool operator>(Student a, Student b) 
        {
            if (a.average == b.average)
            {
                if (a.self > b.self)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return a.average > b.average;
            }
        }
        public static bool operator<(Student a, Student b)
        {
            if (a.average == b.average)
            {
                if (a.self < b.self)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return a.average < b.average;
            }
        }

        public static bool operator >(Student a, double passingGrade)
        {
            return a.average > passingGrade;
        }
        public static bool operator <(Student a, double passingGrade)
        {
            return a.average < passingGrade;
        }
    }

}
