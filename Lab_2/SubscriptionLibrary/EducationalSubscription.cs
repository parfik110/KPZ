using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionLibrary
{
    public class EducationalSubscription : Subscription
    {
        public override string Name => "Educational Subscription";
        public override decimal MonthlyFee => 7.99m;
        public override int MinSubscriptionPeriod => 3;
        public override List<string> Channels => new List<string> { "Science", "History", "Discovery" };
        public override List<string> Features => new List<string> { "Ad-Free", "Exclusive Content" };
    }
}
