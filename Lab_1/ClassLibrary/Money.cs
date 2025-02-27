using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Money
    {
        public int Whole { get; private set; }
        public int Cents { get; private set; }
        public string Currency { get; private set; }

        public Money(int whole, int cents, string currency)
        {
            Whole = whole;
            Cents = cents;
            Currency = currency;
        }

        public override string ToString() => $"{Whole}.{Cents:D2} {Currency}";

        public void SetValue(int whole, int cents)
        {
            Whole = whole;
            Cents = cents;
        }
    }
}
