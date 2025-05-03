using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public interface INodeVisitor
    {
        void VisitElement(LightElementNode element);
        void VisitText(LightTextNode text);
        void VisitImage(LightImageNode image);
    }
}
