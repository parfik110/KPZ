using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionLibrary
{
    public class PremiumSubscription : Subscription
    {
        public override string Name => "Premium Subscription";
        public override decimal MonthlyFee => 19.99m;
        public override int MinSubscriptionPeriod => 4;
        public override List<string> Channels => new List<string> { "All Channels", "4K Movies", "Live Sports" };
        public override List<string> Features => new List<string> { "Ad-Free", "HD Streaming", "Exclusive Content", "Multiple Devices", "Offline Viewing" };
    }
}
