using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    internal class FeaturesCupcakes
    {
        private string _name;
        private int _price;
        private int _weight;
        private int _calories;

        public string Name { get { return _name; } set {_name = value; } }
        public int Price { get { return _price; } set { _price = value; } }

        public int Calories { get { return _calories; } }

        public string Compound { get; }

        public string Info => $"Название: {Name}, Цена: {Price}, Вес: {_weight}, Калорийность: {Calories}, Состав: {Compound}";


        public FeaturesCupcakes(string name, int price, int weight, int calories, string compound)
        {
            _name = name;
            _price = price;
            _weight = weight;
            _calories = calories;
            Compound = compound;
            Name = name;
            Price = price;
        }
    }
}
