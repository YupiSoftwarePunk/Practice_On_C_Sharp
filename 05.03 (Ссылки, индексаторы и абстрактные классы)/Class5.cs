using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracice5
{
    public class Class5
    {
        public virtual void Asd()
        {
            Console.WriteLine("asd");
        }
    }

    public class Class6 : Class5
    {
        public override void Asd() 
        {
            Console.WriteLine("qwerty");
        }
    }

    // абстрактный метод - объявлен в абстрактом классе и не содержит реализацию метода, должны быть переопределены в дочерних классах с помошбю override
    // абстрактные методлы могут быть только в абстрактных классах
    public abstract class Class7  // нельзя создать объект этого класса   // может содержать как абстрактные так и не абстрактные методы
    {                                   
        public abstract void Asd();
    }


    // Разница между интерфейса и абстрактного класса

    // абстрактный класс может содержать поля, а интерфейс нет
    // интерфейсы содеражат только свойства
    // в абстрактном классе нет множественного наследования


    public class Class8 : Class7
    {
        // индексаторы
        private int[] ints;
        public int this[int index]
        {
            get { return ints[index]; }
            set{ ints[index] = value; }
        }

        public override void Asd()
        {
            Console.WriteLine("123456");
        }

        public Class8(int size)
        {
            ints = new int[size];
        }
    }
}
