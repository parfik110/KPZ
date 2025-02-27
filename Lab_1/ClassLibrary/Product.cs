using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Product
    {
        public string Name { get; private set; }
        public Money Price { get; private set; }
        public string Category { get; private set; }

        public Product(string name, Money price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        public void ReducePrice(Money amount)
        {
            int totalCents = Price.Whole * 100 + Price.Cents;
            int reductionCents = amount.Whole * 100 + amount.Cents;
            int newTotalCents = Math.Max(0, totalCents - reductionCents);
            Price = new Money(newTotalCents / 100, newTotalCents % 100, Price.Currency);
        }

        public override string ToString() => $"{Name} - {Price} ({Category})";
    }
}
