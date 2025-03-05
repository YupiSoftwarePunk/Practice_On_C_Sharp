using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracice5
{
    public class Class1
    {
        private string name;
        private int age;
        public string surName;

        public Class1(string name) : this(name, 0, "") { }
        public Class1(string name, int age) : this(name, age, ""){ }
        public Class1(string name, int age, string surName) 
        {
            this.name = name;
            this.age = age;
            this.surName = surName;
        }

        public void Method1(Class2 c)
        {
            c.Method2(this);
        }
        public void Method3(ref int a)
        {
            a++;
        }


    }


    public class Class2
    {
        public void Method2(Class1 c) 
        {
                    
        }


    }
}
