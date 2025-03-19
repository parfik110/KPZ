using FactoryLibrary;

class Program
{
    static void Main()
    {
        ITechFactory[] factories = { new IProneFactory(), new KiaomiFactory(), new BalaxyFactory() };

        foreach (var factory in factories)
        {
            var laptop = factory.CreateLaptop();
            var netbook = factory.CreateNetbook();
            var ebook = factory.CreateEBook();
            var smartphone = factory.CreateSmartphone();

            laptop.ShowInfo();
            netbook.ShowInfo();
            ebook.ShowInfo();
            smartphone.ShowInfo();

            Console.WriteLine();
        }
    }
}