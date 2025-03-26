using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    public class Bus : PublicTransport
    {
        private int _tankCapacity;

        public Bus(int number, int capacity, int speed, int tankCapacity) 
            : base(number, capacity, speed)
        {
            _tankCapacity = tankCapacity;
        }

        public override string Info()
        {
            return $"{base.Info()}, вместимость бака: {_tankCapacity}";
        }

        public int GetDistance()
        {
            return _tankCapacity / 20 * 25;
        }
    }
}
