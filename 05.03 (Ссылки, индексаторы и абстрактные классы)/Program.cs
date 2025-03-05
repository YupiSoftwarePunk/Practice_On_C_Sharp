namespace Pracice5
{

/*
 this -  ссылка на экземпляр этого класса
 конструктор с наибольшим кол-вом параметров - главный
 */

    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new("asd");

            int a = 1;

            c.Method3(ref a);

            Console.WriteLine(a);

            Class8 class8 = new Class8(5);

            // индексаторы
            class8[0] = 12;
            class8[1] = 66;
            class8[2] = 33;
            Console.WriteLine(class8[0]);
        }
    }
}
