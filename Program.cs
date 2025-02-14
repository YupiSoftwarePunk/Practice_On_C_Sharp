namespace New_proj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");


            /*
            Примитивные типы данных
            int
            float (32)
            double (64) - влезает больше чисел после запятой
            bool
            char ''
            string
            все типы данных - классы

            целочисленные
            byte (0 - 255)
            short (-32768 - 32767)
            int (4 байта)
            long (12L)
            unsigned (uint 12)

            дробные
            float - 7 знаков после запятой (12.5f)
            double - 15-16 знаков после запятой
            decimal - 28-29 знаков после запятой

            синтаксис объявления
            тип название = значение;

            неявная типизация
            var a = 10; // тип определяется на этапе компиляции

            операторы
            арифметические   - + * / % 
            сравнения < > == != <= >=
            присваивания += -= *= /= = 
            инкремент декремент ++ -- префиксные и постфиксные
            логические || && !

            приоритеты (* /) > (+ -), (|| &&) > (> < ==)

            управляюшие конструкции
            условные операторы if else-if else
            циклы for while do-while

             */

            //for (int i = 0; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine($"{i} - четное");
            //    }
            //    else 
            //    {
            //        Console.WriteLine($"{i} - нечетное");
            //    }
            //}


            //string a = Console.ReadLine();

            //int num = 0;
            //do
            //{
            //    Console.Write("Введите число: ");
            //    num = int.Parse(Console.ReadLine());

            //    if (num == 7)
            //    {
            //        Console.WriteLine("Вы угадали число");
            //    }
            //    else if (num < 7)
            //    {
            //        Console.WriteLine("Число должно быть больше");
            //    }
            //    else if (num > 7)
            //    {
            //        Console.WriteLine("Число должно быть меньше");
            //    }
            //} while (num != 7);


            int num;
            int maxNum = int.MinValue;
            string strNum;

            while (true)
            {
                Console.Write("Введите число: ");
                strNum = Console.ReadLine();

                if (strNum == "")
                {
                    break;
                }

                num = int.Parse(strNum);
                if (maxNum < num)
                {
                    maxNum = num;
                }
            }
            Console.WriteLine(maxNum);



            /*
             * Массивы
             * тип[] имя = new тип[размер] 
             * тип[] имя = {12, 22, 33, 444, 55, 0}
             * int a = nums[1] - O(1)
             * пробежаться по массиву можно: 
             * for ()
             * foreach ()
             * 
             * многомерные массивы
             * int[,] asd = new int[3, 3]
             * int [, , ] asd2 = new int [3, 3, 3]
             * 
             * зубчатый массив - массив с массивами
             * int [][] ints = new int [3][]
             * 
             * двумерный массив и зубчатый масив отличаются тем, что у двумерных массивов обязательно нужно указывать длину, а в зубчатом не нужно 
             * и можно записать любой размер
             */
        }
    }
}

