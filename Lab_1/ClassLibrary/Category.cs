using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Category
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public Category(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override string ToString() => Name;
    }
}
