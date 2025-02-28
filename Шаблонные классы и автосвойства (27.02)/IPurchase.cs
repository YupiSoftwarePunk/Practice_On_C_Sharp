using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public interface IPurchase
    {
        static string PurchaseType { get; }
        public double Sum { get; set; }

        public string GetPurchType() => $"Сумма оплаты: {Sum}";
    }
}
