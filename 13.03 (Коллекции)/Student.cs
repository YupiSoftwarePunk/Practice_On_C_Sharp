using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPractice13._02
{
    public class Student
    {
        public string Name { get; }
        public string Faculty { get; }
        public List<int> Grades { get; }


        public string Info() => $"Name: {Name}, Faculty: {Faculty}, Grades: {Grades}, Average grade: {AverageGrade()}";

        public double AverageGrade() => Grades.Sum() / Grades.Count;

        //public int ShowGrades()
        //{
        //    for (int i = 0; i < Grades.Count; i++)
        //    {
        //        yield return Grades[i];
        //    }
        //}

        public Student(string name, string faculty, List<int> grades)
        {
            Name = name;
            Faculty = faculty;
            Grades = grades;
        }
    }
}
