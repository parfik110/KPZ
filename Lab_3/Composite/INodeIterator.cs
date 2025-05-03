using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public interface INodeIterator
    {
        bool HasNext();
        LightNode Next();
    }
}
