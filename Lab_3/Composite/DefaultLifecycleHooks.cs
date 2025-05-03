using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class DefaultLifecycleHooks : LightLifecycleHooks
    {
        public override void OnCreated(LightElementNode element)
        {
            Console.WriteLine($"[Lifecycle] Created: <{element.TagName}>");
        }

        public override void OnInserted(LightElementNode element)
        {
            Console.WriteLine($"[Lifecycle] Inserted: <{element.TagName}>");
        }

        public override void OnRendered(LightElementNode element)
        {
            Console.WriteLine($"[Lifecycle] Rendered: <{element.TagName}>");
        }

        public override void OnRemoved(LightElementNode element)
        {
            Console.WriteLine($"[Lifecycle] Removed: <{element.TagName}>");
        }
    }
}
