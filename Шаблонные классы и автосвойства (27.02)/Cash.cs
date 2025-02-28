using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public struct Cash : IPurchase
    {
        public double Sum { get; set; }
        public string PurchaseType => _type;
        private static readonly string _type = "Наличный";
        public double Change { get; set; }
    }
}
