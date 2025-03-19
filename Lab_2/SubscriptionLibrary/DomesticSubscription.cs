using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionLibrary
{
    public class DomesticSubscription : Subscription
    {
        public override string Name => "Domestic Subscription";
        public override decimal MonthlyFee => 10.99m;
        public override int MinSubscriptionPeriod => 6;
        public override List<string> Channels => new List<string> { "Local News", "Sports", "Movies" };
        public override List<string> Features => new List<string> { "HD Streaming" };
    }
}
