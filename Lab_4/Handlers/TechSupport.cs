using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handlers
{
    public class TechSupport : SupportHandler
    {
        public override bool Handle(string issue)
        {
            if (issue.ToLower() == "tech")
            {
                Console.WriteLine("Проблема передана до Tech Support.");
                return true;
            }
            return next?.Handle(issue) ?? false;
        }
    }
}
