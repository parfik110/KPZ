using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class HiddenState : IElementState
    {
        public string Name => "Hidden";

        public void ApplyState(LightElementNode element)
        {
            element.AddStyle("display", "none");
        }
    }
}
