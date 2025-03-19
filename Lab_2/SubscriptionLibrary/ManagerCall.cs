using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionLibrary
{
    public class ManagerCall : SubscriptionFactory
    {
        public override Subscription CreateSubscription() => new PremiumSubscription();
    }
}
