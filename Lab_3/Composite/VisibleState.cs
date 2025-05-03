using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class VisibleState : IElementState
    {
        public string Name => "Visible";

        public void ApplyState(LightElementNode element)
        {
            element.AddStyle("display", "block");
        }
    }
}
