using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class HtmlPrinterVisitor : INodeVisitor
    {
        public void VisitElement(LightElementNode element)
        {
            Console.WriteLine($"[Element] <{element.TagName}>");
        }

        public void VisitText(LightTextNode text)
        {
            Console.WriteLine($"[Text] {text.InnerHTML}");
        }

        public void VisitImage(LightImageNode image)
        {
            Console.WriteLine($"[Image] src=\"{image.Source}\" alt=\"{image.Strategy.Load(image.Source)}\"");
        }
    }
}
