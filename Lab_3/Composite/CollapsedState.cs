using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class CollapsedState : IElementState
    {
        public string Name => "Collapsed";

        public void ApplyState(LightElementNode element)
        {
            element.AddStyle("display", "none");
            element.AddStyle("visibility", "hidden");
        }
    }
}
