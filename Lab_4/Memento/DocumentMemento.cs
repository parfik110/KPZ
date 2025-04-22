using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class DocumentMemento
    {
        public string SavedContent { get; }

        public DocumentMemento(string content)
        {
            SavedContent = content;
        }
    }
}
