using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice2
{
    public class MethodCupcakes
    {
        private string _name;
        private int _price;
        private int _weight;
        private int _calories;
        private string _compound;

        public void SetName(string name) => _name = name;
        public string GetName() => _name;


        public int GetPrice() => _price;
        public void SetPrice(int price) => _price = price;

        public string GetCompound() => _compound;

        public int GetCalories() => _calories;

        public string Info => $"Название: {_name}, Цена: {_price}, Вес: {_weight}, Калорийность: {_calories}, Состав: {_compound}";
    }
}
