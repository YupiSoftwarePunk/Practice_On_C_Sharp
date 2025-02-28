namespace Practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher t1 = new Teacher("Jake", 38, 18, 2);
            Teacher t2 = new Teacher("Anny", 25, 5, 1);

            Student s = new Student("Artem", 17, 2, 2);

            Console.WriteLine(t1.Info());
            Console.WriteLine(t2.Info());
            Console.WriteLine(s.Info());

            Console.WriteLine("\n");

            Bus b = new Bus(1212, 33, 50, 500);
            Trolleybus tr = new Trolleybus(35, 40, 45, 1000);

            Console.WriteLine(b.Info());
            Console.WriteLine(tr.Info());
            Console.WriteLine(b.GetDistance());
            Console.WriteLine(tr.GetDistance());
        }
    }
}
