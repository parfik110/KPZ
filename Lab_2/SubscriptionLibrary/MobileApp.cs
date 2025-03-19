﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionLibrary
{
    public class MobileApp : SubscriptionFactory
    {
        public override Subscription CreateSubscription() => new EducationalSubscription();
    }
}
