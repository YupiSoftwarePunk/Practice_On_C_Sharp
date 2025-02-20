// Перегрузка операторов

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Figure.V(12.2));
            Console.WriteLine(Figure.V(12.22, 34.11, 99.6));

            Console.WriteLine(Number.PrintMax(12, 10));
        }
    }
}