using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    public class Student : People
    {
        private int _course;
        private int _group;

        public Student(string name, int age, int course, int group)
            : base(name, age)
        {
            _course = course;
            _group = group;
        }

        public override string Info()
        {
            return $"{base.Info()}, курс: {_course}, Группа: {_group}\n";
        }
    }
}
