using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    public class Trolleybus : PublicTransport
    {
        private int _accCapacity;

        public Trolleybus(int number, int capacity, int speed, int accCapacity)
            : base(number, capacity, speed)
        {
            _accCapacity = accCapacity;        
        }

        public override string Info()
        {
            return $"{base.Info()}, вместимость аккумулятора: {_accCapacity}";
        }

        public int GetDistance()
        {
            return _accCapacity / 200 * 70;
        }
    }
}
