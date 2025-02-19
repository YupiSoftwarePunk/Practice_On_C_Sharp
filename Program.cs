namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Point point = new Point(10, 20, 30);

            //point.Print();

            //point.MoveBy(1, 5, 25);

            //point.Print();

            Pc pc = new Pc("Asus ROG 12555", 12.22, 32, 1000);
            pc.Info();

            User user = new User("Alex", "Smith", "Peter", 22);
            user.Info();

            PostOffice postOffice = new PostOffice(66778839, "NY", "Wall st.", 22, 45, 195, "hello");
            postOffice.Info();
        }
    }
}
