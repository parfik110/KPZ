using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibrary
{
    class IProneLaptop : ILaptop { public void ShowInfo() => Console.WriteLine("IProne Laptop"); }
    class IProneNetbook : INetbook { public void ShowInfo() => Console.WriteLine("IProne Netbook"); }
    class IProneEBook : IEBook { public void ShowInfo() => Console.WriteLine("IProne EBook"); }
    class IProneSmartphone : ISmartphone { public void ShowInfo() => Console.WriteLine("IProne Smartphone"); }
}
