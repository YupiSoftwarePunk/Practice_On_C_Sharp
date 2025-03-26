using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public class ExcursionTour<T> where T : ITransport
    {
        public string TouristName { get; set; }
        public T Transport { get; set; }
        public int Duration { get; set; }
        public string Hotel { get; set; }

        public string GetInfo() => $"Имя туриста: {TouristName}, длительность: {Duration}, отель: {Hotel}, транспорт: {Transport}";
    }
}
