using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibrary
{
    class BalaxyLaptop : ILaptop { public void ShowInfo() => Console.WriteLine("Balaxy Laptop"); }
    class BalaxyNetbook : INetbook { public void ShowInfo() => Console.WriteLine("Balaxy Netbook"); }
    class BalaxyEBook : IEBook { public void ShowInfo() => Console.WriteLine("Balaxy EBook"); }
    class BalaxySmartphone : ISmartphone { public void ShowInfo() => Console.WriteLine("Balaxy Smartphone"); }
}
