using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    public class PublicTransport
    {
        private int _number;
        private int _capacity;
        private int _speed;

        public PublicTransport(int number, int capacity, int speed)
        {
            _number = number;
            _capacity = capacity;
            _speed = speed;
        }

        public virtual string Info()
        {
            return $"Номер: {_number}, вместимость: {_capacity}, скорость: {_speed}";
        }
    }
}
