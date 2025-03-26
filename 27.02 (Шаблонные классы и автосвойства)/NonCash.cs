using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public struct NonCash : IPurchase
    {
        public string PurchaseType => _type;
        private static readonly string _type = "Безналичный";
        public int CardNum { get; set; }
        public double Sum { get; set; }
        public string DateIssuance { get; set; }
        public string FIO { get; set; }
        public int Cvc { get; set; }

    }
}
