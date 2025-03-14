using System.Collections;

namespace NewPractice13._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // коллекции
            List<string> list = new List<string>();    // динамический массив
            Dictionary<int, string> dict = new Dictionary<int, string>();     // список, у которого ключом может быть все что угодно
            Queue<string> queue = new Queue<string>();   // очередь - коллекция, которая позволяет добавлять элемнт в начало или конец и выдавать ее по ключу важности (первый зашел - первый вышел)
            Stack<string> stack = new Stack<string>();  // стэк - (последний зашел - первый вышел)  коллекция, которая работает по аналогии с тарелками, когда кладешь наверх и сразу моешь
            ArrayList arrayList = new ArrayList();   // массив, который хранит все что угодно, динамический массив
            SortedList<int, string> sortedList = new SortedList<int, string>();  // отсортированный список, который сортирует список по ключам, хранит пару (ключ, значение)
            Hashtable hashtable = new Hashtable();  // словарь, который в ключе может принимать все что угодно, это как ArrayList только он еще хранит значение


            // List, Dictionary - знать и часто встречатся
            // Queue, Stack - знать, но используется редко



            // Интерфейсы коллекций
            /*
             * ICollection - основная коллекция, используется для добавления, удаления и работы с элементами в коллекции
             * IList - расширяет интерфейс ICollection и используется для индексации коллекции, также имеет все методы для взаимодействия с коллекцией, делает упорядоченной ICollection
             * IDictionary - рсширяет IList и используется для задания ключа и значения в коллекции, также имеет все методы для взаимодействия с коллекцией, удаляет значение по ключу
             * IDictionary Ienumerable - расширяет IDictionary, используется в Hashtable
             */


            // задачка 1
            Dictionary<string, string> engToRus = new Dictionary<string, string>();
            Dictionary<string, string> rusToEng = new Dictionary<string, string>();
            // англо-русский словарь
            engToRus.Add("Russia", "Россия");
            engToRus.Add("USA", "США");
            engToRus.Add("UK", "Великобритания");
            engToRus.Add("China", "Китай");

            // русско-английский словарь
            rusToEng.Add("Россия", "Russia");
            rusToEng.Add("США", "USA");
            rusToEng.Add("Великобритания", "UK");
            rusToEng.Add("Китай", "China");

            Console.WriteLine("С какого языка на какой вам перевести?");
            Console.WriteLine("1. Русский-Английский\n2. Английский-Русский");
            try
            {
                int choise = Convert.ToInt32(Console.ReadLine());
                if (choise == 1)
                {
                    Console.Write("Введте слово для поиска: ");
                    string word = Console.ReadLine();
                    Console.WriteLine($"Ответ: {rusToEng[word]}");
                }
                else if (choise == 2)
                {
                    Console.Write("Введте слово для поиска: ");
                    string word = Console.ReadLine();
                    Console.WriteLine($"Ответ: {engToRus[word]}");
                }
                else
                {
                    throw new Exception("Ошибка!! Ввод может быть только 1 или 2");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }



            // задача 2

            List<Student> students = new List<Student>()
            {
                new Student("Alex", "phisics", new List<int>{ 2, 4, 5 }),
                new Student("Lola", "maths", new List<int>{ 3, 2, 3 }),
                new Student("Martin", "science", new List<int>{ 1, 4, 2 }),
                new Student("Grab", "science", new List<int>{ 5, 3, 5 }),
                new Student("Sara", "phisics", new List<int>{ 2, 2, 3 })
            };

            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i].Info());
            }

            Dictionary<string, List<Student>> facultyGroup = new Dictionary<string, List<Student>>();
            // Групировка по фокультативам
            foreach (var student in students)
            {
                if (!facultyGroup.ContainsKey(student.Faculty))
                {
                    facultyGroup[student.Faculty] = new List<Student>();
                }
                facultyGroup[student.Faculty].Add(student);
            }

            // Обработка студентов по факультетам
            foreach (var faculty in facultyGroup)
            {
                string facultyName = faculty.Key;
                List<Student> studentsInFaculty = faculty.Value;

                // расчет общего среднего балла факультета
                double totalSum = 0;
                int totalGrades = 0;
                foreach (Student student in studentsInFaculty)
                {
                    foreach (var grade in student.Grades)
                    {
                        totalSum += grade;
                        totalGrades++;
                    }
                }
                double facultyAverage = totalSum / totalGrades;

                // ищем лучщего студента 
                Student best = null;
                double maxAverage = 0;
                foreach (Student student in studentsInFaculty)
                {
                    double average = student.AverageGrade();
                    if (student.AverageGrade() > maxAverage || best == null)
                    {
                        maxAverage = average;
                        best = student;
                    }
                }
                Console.WriteLine($"Факультет: {facultyName}");
                Console.WriteLine($"Средний балл: {facultyAverage}");
                Console.WriteLine($"Лучший студент: {best.Name}," + $"средний балл: {maxAverage}");
            }
        
        }
    }
}
