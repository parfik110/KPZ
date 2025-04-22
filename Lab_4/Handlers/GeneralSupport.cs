using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handlers
{
    public class GeneralSupport : SupportHandler
    {
        public override bool Handle(string issue)
        {
            if (issue.ToLower() == "general")
            {
                Console.WriteLine("Проблема передана до General Support.");
                return true;
            }
            return false;
        }
    }
}
