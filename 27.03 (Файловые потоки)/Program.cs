using System.Runtime.Serialization.Formatters.Binary;

namespace NewPractice_27._03_
{
    /*
     файловые потоки
    сереализация и десерилизация - выделение определенного объекта или части кода и перевод его в другой формат такой как json, xml или другой

     Stream - поток ввода и вывода для файлов - работает с байтовыми данными
    Stream - абстрактный класс для работы с файлами

    FileStream - не абстрактный класс, наследуется от Stream - работает с байтовыми данными
    буфер - временное хранение данных в памяти и имеет объем 4096 байт

    StreamWriter - предназначен для записи в файлы, используются в Stream
    StreamReader - предназначен для чтения файлов


    атрибут объекта - атрибуты в [], это характеристика объекта
    [DebuggedDisplay("")]
     */



    /*
     * Directory - статический класс для работы с папками или директориями. Можно создавать, удалять и изменять папки
     * в этом классе существует множество методов для различных проверок по папкам (имя, содержимое и другое)
     * чтобы работать с разными директориями можно работать с одним объектом класса
     * этот класс работает с методами
     * 
     * методы:
     * 
     * CreateDirectory()
     * Delete()
     * Exists()
     * GetFiles()
     * GetDirectories()
     * Move()
     */



    /*
     * DirectoryInfo - нестатический класс, который глобальный и принимает любую директорию в свой конструктор
     * чтобы работать с разными директориями нужно создавать разные объекты класса
     * этот класс работает с объектами
     * 
     * при создании DirectoryInfo не создается новый объект, если она отсутствует ее можно создать
     * 
     * тут есть все теже методы, которые есть в Directory
     */



    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = "C:\\Users\\Top\\Downloads\\NewPractice(27.03)\\data.bin";

            using (StreamReader sr = new StreamReader(filepath))
            {
                Console.WriteLine(sr.ReadToEnd());   // чтение всего файла

                //Console.WriteLine(sr.ReadLine());   // чтение одной строки 


                // чтение всего файла другим способом 
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                /* Read() - один символ 
                 ReadLine() - строка
                 ReadToEnd() - читает файл до конца
                 */

            }


            // using - асинхронность
            using (StreamWriter sw = new StreamWriter(filepath, true))  // true - Означает что текст добавляется в конец уже написанного текста
            {
                sw.WriteLine("\nHello");

                /*
                 WriteLine() - записть строки с переносом
                 Write() - записть строки без переноса
                 */
            }


            using (FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate))  // поток
            {
                using (BinaryReader br = new BinaryReader(fs))   // взаимодействие с потоком
                {




                    //Console.WriteLine($"{br.ReadString()}");   // работает только с бинарными файлами

                    /*
                    ReadBoolean()
                    ReadByte() - это самое нужное и читает 1 байт из файла
                    ReadSingle() - чтение float
                    ReadInt()
                    ReadDouble()
                    ReadString()
                     */
                }
            }

            using (StreamWriter sr = new StreamWriter(filepath))
            {
                sr.WriteLine("hell no");
            }


            var account = new PaymentAccount { DailyPayment = 100, NumberOfDays = 30, PenaltyPerDay = 10, DelayDays = 5 };
            Console.WriteLine(account.ToString());

            using (FileStream fs = new FileStream("account.dat", FileMode.OpenOrCreate))
            {
                BinaryFormatter bf = new BinaryFormatter();   // это устарело и не работает 
            }

        }
    }
}
