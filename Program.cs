using System.Linq;

namespace ConsoleApp
{

    // опфускауия - запутывание кода
    // nullable - тип данных который может принимать null
    // int? a = null;     - обозначение то что число null (string к примеру)
    internal class Program
    {
        static void Main(string[] args)
        {


            // 2 способа преобразования а int
            //int.Parse(Console.ReadLine());
            //Convert.ToInt32(Console.ReadLine());

            //object s = c;    // boxing (Упаковка)
            //c = (float)s;    // unboxing (распаковка)

            // Строки
            /*
             * string name = "value";
             * string str = new string(Console.ReadLine())
             * string str2 = new string(Console.ReadLine())
             * 
             * индексация строк
             * str[0]
             * int a = str.Lenght
             * char[] chars = new char [str]
             * asd.CopyTo(chars)
             * 
             * str.Equals(chars)  - сравнивает строки между собой (по значению)
             * String.Compare(str, str2)    // сравнивает строки между собой (по значению)
             * str.Contains(str2)   - проверияет входит ли параметр в строку
             * str.Replace('a', 'b')  - заменяет символы
             * str.Split('.')  - разделяет строку
             * String.Join(" ", chars)  - объединяет строки, а в данном случае есть неявное преобразование
             * 
             * Форматирование строк
             * 
             * 1. конкатенация - сложение строк
             * string c = str + str2
             * 
             * 2. интерполяция - встраивание строк
             * Console.WriteLine($"{12} - even")
             * 
             * 3. Format
             * string.Format("asd{0} ", 12)
             * 
             * StringBuilder strBldr = new StringBuilder()
             * strBldr.Append(3)
             * string str3 = strBldr.ToString()
             * 
             * 
             * 
             * Перечисление  (enum)
             * 
             * enum название {}
             * enum нульзя создавать в методах. Их нужно создавать в классе или вне класса (в поле namespace)
             * 
             * enum DayOfWeek
             * {
             * monday
             * tuesday
             * wednesday
             * thirsday
             * friday
             * saturday
             * sunday
             * }
             * 
             * int num = (int) DayOfWeek.monday
             * Console.WriteLine(DayOfWeek.monday)
             * Console.WriteLine(num)
             */





            //Console.Write("Введите число:");
            //int num = int.Parse(Console.ReadLine());

            //int[] numbers = { 12, 11, 22, 33, 44, 12, 11, 0, 1, 2, 99};
            ////int counter = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i] + " ");
            //}
            //Console.WriteLine("\n\n");
            //for (int i = 0; i < numbers.Length / 2; i++) 
            //{
            //    int temp = numbers[i];
            //    numbers[i] = numbers[numbers.Length - 1 - i];
            //    numbers[numbers.Length - 1 - i] = temp;
            //}
            //for (int i = 0;i < numbers.Length;i++)
            //{
            //    Console.Write(numbers[i] + " ");
            //}




            //Console.WriteLine("Заполните массив 3x3");

            //int[,] numbers = new int[3, 3];
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write("Введите число: ");
            //        numbers[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine();
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(numbers[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}





            //string dict = "aeyuioAEYUIO";
            //int counter = 0;
            //Console.WriteLine("Введите строку: ");
            //string sent = Convert.ToString(Console.ReadLine());
            //for (int i = 0; i < sent.Length; i++)
            //{
            //    if (dict.Contains(sent[i]))
            //    {
            //        counter++;
            //    }
            //}

            //Console.WriteLine(counter);



            Console.WriteLine("Введите строку: ");
            string sent = Convert.ToString(Console.ReadLine().ToLower());
            string sent2 = "";
            for (int i = sent.Length - 1; i >= 0; i--)
            {
                sent2 += sent[i];
            }
            if (sent.Equals(sent2))
            {
                Console.WriteLine($"строка {sent} - полиндром");
            }
            else
            {
                Console.WriteLine($"строка {sent} - не полиндром");
            }
        }

    }
}