using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Reporting
    {
        public static void RegisterIncome(Warehouse warehouse, Product product, int quantity)
        {
            warehouse.AddProduct(product, quantity);
            Console.WriteLine($"Income registered: {product.Name} x{quantity}");
        }
    }
}
