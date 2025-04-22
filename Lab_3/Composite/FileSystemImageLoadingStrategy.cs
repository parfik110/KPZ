using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class FileSystemImageLoadingStrategy : IImageLoadingStrategy
    {
        public string Load(string source)
        {
            
            return $"[Image loaded from file system: {source}]";
        }
    }
}
