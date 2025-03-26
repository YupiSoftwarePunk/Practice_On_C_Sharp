using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace NewPractice_26._03_
{

    /*
     ковариантность и контравариантность
    кавариантность - это возможность использовать более производный тип, чем заявлено
     IEnumerable< out T> - ковариантен, так как использует ключевое слово out
     ковариантность - динамический полиморфизм только в Generic классах
    массив всегда ковариантен

    IEnumerable<Dog> dogs = new List<Dog>();
    IEnumerable<Animal> animals = dogs;     - это и есть ковариантность


    контравариантность - полная противоположность ковариантности
    контравариантность - это возможность использовать более базовый тип, чем заявлено
    ICompare< in T> - контравариантен, так как использует ключевое слово in

    ICompare<Animal> animals = ....
    ICompare<Dog> dogs = animals;     - это контрвариантность
     */





    internal class Program
    {
        static void Main(string[] args)
        {
            //IEnumerable<Dog> dogs = new List<Dog>();
            //IEnumerable<Animal> animals = dogs;    // это и есть ковариантность

            //Animal[] animals1 = new Dog[5];    // При добавлении элементов возникнут ошибки
            //animals1[0] = new Dog();
            //animals1[1] = new Animal();  // тут будет ошибка, так как массив может содержать только 1 тип данных


            //foreach (ref var i in animals.AsSpan())  // так можно сделать их foreach -> for
            //{

            //}

            var people = new List<People>
            { 
                new People {Name = "asas", FirstName = "qwerty", Id =  1},
                new People {Name = "sdvf", FirstName = "45fd", Id =  2},
                new People {Name = "asghnjas", FirstName = "kl", Id =  3},
                new People {Name = "tyhjg", FirstName = "hjk", Id =  4},
                new People {Name = "rt", FirstName = "bnm", Id =  5}
            };
            Console.WriteLine(people);
        }

        [DebuggerDisplay("Человек под номером {Id}")]

        //public class Animal {

        //    //void MethodArr<T>(T[] arr) { }
        //}
        //public class Dog : Animal { }

        //public class Gen<T>
        //{
        //    public T[] arr = new T[10];
        //}

        public class People
        {
            public string Name { get; set; }
            public string FirstName { get; set; }
            public int Id { get; set; }
        }

    }
}
