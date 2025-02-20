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

            Student bob = new Student("Bob Peter Andersen", 3.5, 5, "15.07.2024");
            Student sue = new Student("Sue Augustina Lorenzzo", 5, 3, "21.07.2024");
            Student victor = new Student("Victor Petrovich Diakonov", 5, 5, "30.07.2024");

            Console.WriteLine("Bob better Sue? " + (bob > sue));
            Console.WriteLine("Victor better Sue? " + (victor > sue));
            Console.WriteLine("Bob better Victor? " + (bob > victor));

            Console.WriteLine("Bob has passed? " + (Admission.IsPass(bob)));
            Console.WriteLine("Victor has passed? " + (Admission.IsPass(victor)));
            Console.WriteLine("Sue has passed? " + (Admission.IsPass(sue)));
        }
    }
}
