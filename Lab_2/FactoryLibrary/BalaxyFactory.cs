using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibrary
{
    public class BalaxyFactory : ITechFactory
    {
        public ILaptop CreateLaptop() => new BalaxyLaptop();
        public INetbook CreateNetbook() => new BalaxyNetbook();
        public IEBook CreateEBook() => new BalaxyEBook();
        public ISmartphone CreateSmartphone() => new BalaxySmartphone();
    }
}
