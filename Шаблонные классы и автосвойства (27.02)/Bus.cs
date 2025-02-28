using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public struct Bus : ITransport
    {
        private static readonly string _type = "Поезд";
        public string Type => _type;
        public int Number { get; set; }
        public double TravelTime { get; set; }
        public int SeatCount { get; set; }
        public string GetDetails() => $"Кол-во мест: {SeatCount}";
    }
}
