using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handlers
{
    public class AccountSupport : SupportHandler
    {
        public override bool Handle(string issue)
        {
            if (issue.ToLower() == "account")
            {
                Console.WriteLine("Проблема передана до Account Support.");
                return true;
            }
            return next?.Handle(issue) ?? false;
        }
    }
}
