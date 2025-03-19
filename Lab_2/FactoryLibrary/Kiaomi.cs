using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibrary
{
    class KiaomiLaptop : ILaptop { public void ShowInfo() => Console.WriteLine("Kiaomi Laptop"); }
    class KiaomiNetbook : INetbook { public void ShowInfo() => Console.WriteLine("Kiaomi Netbook"); }
    class KiaomiEBook : IEBook { public void ShowInfo() => Console.WriteLine("Kiaomi EBook"); }
    class KiaomiSmartphone : ISmartphone { public void ShowInfo() => Console.WriteLine("Kiaomi Smartphone"); }
}
