using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public class FromCelToKel : Iconverter, Iprintable
    {
        private readonly string _from = "Цельсий";
        private readonly string _to = "Кельвины";

        public string From => _from;
        public string To => _to;

        public double Convert(double value)
        {
            return 273.15 + value;
        }

        public void Print()
        {
            Console.WriteLine($"Конвертация из {From} в {To}");
        }
    }
}
