using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public class Purchase <T> where T : IPurchase
    {
        public int PhoneNum { get; set; }
        public T PurchaseType { get; set; }
        public double Sum { get; set; }

        public string Info() => $"Сумма оплаты: {Sum}, Номер телефона {PhoneNum}, Тип оплаты {PurchaseType}";
    }
}
