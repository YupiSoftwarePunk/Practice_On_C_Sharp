using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public class FromCelToFar : Iconverter, Iprintable
    {
        private readonly string _from = "Цельсий";
        private readonly string _to = "Фаренгейт";

        public string From => _from;
        public string To => _to;

        public double Convert(double value)
        {
            return 1.8 * value + 32;
        }

        public void Print()
        {
            Console.WriteLine($"Конвертация из {From} в {To}");
        }
    }
}
