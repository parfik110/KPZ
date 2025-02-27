namespace ClassLibrary
{
    public class Warehouse
    {
        private List<(Product product, int quantity, DateTime lastSupply)> products = new();

        public void AddProduct(Product product, int quantity)
        {
            products.Add((product, quantity, DateTime.Today));
        }

        public void InventoryReport()
        {
            Console.WriteLine("Inventory Report:");
            foreach (var item in products)
            {
                Console.WriteLine($"{item.product} - {item.quantity} pcs (Last supply: {item.lastSupply:yyyy-MM-dd})");
            }
        }

        public void RemoveProduct(Product product, int quantity)
        {
            var index = products.FindIndex(p => p.product == product);
            if (index != -1)
            {
                var item = products[index];
                if (item.quantity > quantity)
                    products[index] = (item.product, item.quantity - quantity, item.lastSupply);
                else
                    products.RemoveAt(index);
                Console.WriteLine($"Removed {quantity} of {product.Name} from warehouse.");
            }
            else
            {
                Console.WriteLine($"Product {product.Name} not found in warehouse.");
            }
        }
    }
}