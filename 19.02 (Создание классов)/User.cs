using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class User
    {
        private string name;
        private string surName;
        private string secondName;
        int age;

        public User(string name, string surName, string secondName, int age)
        {
            this.name = name;
            this.surName = surName;
            this.secondName = secondName;
            this.age = age;
        }

        public void Info()
        {
            Console.WriteLine($"Name: {name}, Surname: {surName}, Second name: {secondName}, age: {age}\n");
        }
    }
}
