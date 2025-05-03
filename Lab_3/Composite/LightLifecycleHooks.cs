using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class LightLifecycleHooks
    {
        public virtual void OnCreated(LightElementNode element) { }
        public virtual void OnInserted(LightElementNode element) { }
        public virtual void OnRemoved(LightElementNode element) { }
        public virtual void OnRendered(LightElementNode element) { }
    }
}
