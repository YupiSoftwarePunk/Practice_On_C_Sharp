using static IventsAndDelegats.Program;

namespace IventsAndDelegats
{
    // Ивенты и делегаты

    internal class Program
    {
        public delegate void Message();
        public delegate void Notify();
        public event Notify onNotify;   // enent

        public delegate void Available();

        static void Main(string[] args)
        {
            // делегаты
            // делегат - ссылка на метод, безопасная ссылка на метод
            // делегат - массив ссылок на методы (многоадресный делегат), это объект, которых хранит в себе ссылку на первый элемент
            // при вызове делегата все методы из него вызываются поочередно
            // делегаты нужны для событий или ивентов
            // ивент - экземпляр делегата, при вызове ивента вызывается делегат
            // ивент - уведомляет другие объекты о действиях


            // делегаты
            void Hello() => Console.WriteLine("hello");
            void Asd() => Console.WriteLine("qwerty");
            Message mes;
            mes = Hello;
            mes += Asd;
            mes += delegate () { Console.WriteLine("anonimus"); };  // анонимная функция
            mes += () => { Console.WriteLine("lambda"); };  // лямбда функция
            mes();


            Console.WriteLine("\n\n");


            void Helllo(object sender, EventArgs e) { Console.WriteLine("hello"); }
            Button button = new Button();

            button.Click += (sender, args) => { Console.WriteLine("Button clicked"); };
            button.Click += Helllo;
            button.onClick();
            button.Click -= Helllo;
            button.onClick();

            Console.WriteLine("\n\n");


            // LINQ - Language Integrated Query - sql внутри с#, интегрированные запросы 
            // LINQ - делится на 2 раздела - 1
            // query LINQ - декларативный синтаксис
            // var a = from [element_name] in [источник]
            //      <where [условие]>
            //      <orderby [поле] ascendind/descending>
            //      select [выражение];

            // query (declarative) syntax
            var nums = new List<int> { 1, 2, 3, 4, 5 };
            var query = from num in nums
                        where num > 2
                        orderby num descending  // сортировка по убыванию
                        select num;
            Console.WriteLine(query);
            Console.WriteLine(query.ToList());

            foreach (var i in query)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("\n\n");


            // method syntax
            var query1 = nums.Where(num => num > 2).
                OrderByDescending(num => num).
                Select(num => num * num).
                ToList();

            foreach (var i in query1)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("\n\n");

            var students = new List<Student>()
            {
                new Student() { Name = "Bob", Age = 20, Faculty = "Computer Science"},
                new Student() { Name = "Andrew", Age = 23, Faculty = "Biology"},
                new Student() { Name = "Sally", Age = 19, Faculty = "Computer Science"},
                new Student() { Name = "Victoria", Age = 21, Faculty = "Biology"},
                new Student() { Name = "Adam", Age = 24, Faculty = "Computer Science"},
                new Student() { Name = "Peter", Age = 22, Faculty = "Biology"}
            };

            var res = students.Where(i => i.Age > 20).
                GroupBy(i => i.Faculty).
                Select(group => new
                {
                    Faculty = group.Key,
                    Count = group.Count()
                });

            foreach (var i in res)
            {
                Console.WriteLine($"Faculty: {i.Faculty}, count: {i.Count}");
            }



            Console.WriteLine("\n\n");


            //var books = new List<Book>()
            //{
            //    new Book() { Author = "George Orwell", Title = "1984", IsAvailable = true},
            //    new Book() { Author = "George Orwell", Title = "Animal Farm", IsAvailable = false},
            //    new Book() { Author = "Robert Martin", Title = "Clean Code", IsAvailable = true},
            //    new Book() { Author = "Robert Martin", Title = "Clean Architecture", IsAvailable = false},
            //    new Book() { Author = "A. Bhargava", Title = "Grokking algorithms", IsAvailable = true} 
            //};

            //var result = books.GroupBy(i => i.Author).
            //    Select(book => new
            //    {
            //        Author = book.Key
            //    });
            //foreach(var i in result)
            //{
            //    Console.WriteLine($"Author: {i.Author}");
            //}

            //void BookAvailable()
            //{
            //    foreach (var i in books)
            //    {
            //        if (i.IsAvailable)
            //        {
            //            Console.WriteLine("Book is available");
            //        }
            //    }
            //}

            //Console.WriteLine("\n\n");

            //Available available;
            //available = BookAvailable;
            //available();

            Library library = new Library();
            library.AddBook(new Book("George Orwell", "1984", true));
            library.AddBook(new Book("George Orwell", "Animal Farm", false));
            library.AddBook(new Book("Robert Martin", "Clean Code", true));
            library.AddBook(new Book("Robert Martin", "Clean Architecture", false));
            library.AddBook(new Book("A. Bhargava", "Grokking algorithms", true));

            library.BookAvailable += message =>
            {
                Console.WriteLine(message);
            };
            var a = library.FindBook("1984");
            foreach (var i in a)
            {
                Console.WriteLine(i.Title);
            }
            library.UpdateBookStatus("1984", false);
        }
    }
}
