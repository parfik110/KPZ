using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handlers
{
    public class BillingSupport : SupportHandler
    {
        public override bool Handle(string issue)
        {
            if (issue.ToLower() == "billing")
            {
                Console.WriteLine("Проблема передана до Billing Support.");
                return true;
            }
            return next?.Handle(issue) ?? false;
        }
    }
}
