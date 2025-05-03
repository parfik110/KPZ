using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class DepthFirstIterator : INodeIterator
    {
        private Stack<LightNode> stack = new();

        public DepthFirstIterator(LightNode root)
        {
            stack.Push(root);
        }

        public bool HasNext() => stack.Count > 0;

        public LightNode Next()
        {
            var current = stack.Pop();

            if (current is LightElementNode element)
            {
                for (int i = element.Children.Count - 1; i >= 0; i--)
                    stack.Push(element.Children[i]);
            }

            return current;
        }
    }

}
