using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class LightImageNode : LightNode
    {
        public string Source { get; }
        public IImageLoadingStrategy Strategy { get; }

        public LightImageNode(string source, IImageLoadingStrategy strategy)
        {
            Source = source;
            Strategy = strategy;
        }

        public override string InnerHTML => string.Empty;

        public override string OuterHTML
        {
            get
            {
                string result = Strategy.Load(Source);
                return $"<img src=\"{Source}\" alt=\"{result}\" />";
            }
        }
    }
}
