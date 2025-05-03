using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class NetworkImageLoadingStrategy : IImageLoadingStrategy
    {
        public string Load(string source)
        {
            return $"[Image loaded from network: {source}]";
        }
    }
}
