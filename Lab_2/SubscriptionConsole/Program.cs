using System;
using SubscriptionLibrary;

class Program
{
    static void Main()
    {
        SubscriptionFactory webFactory = new WebSite();
        SubscriptionFactory appFactory = new MobileApp();
        SubscriptionFactory callFactory = new ManagerCall();

        Subscription webSubscription = webFactory.CreateSubscription();
        Subscription appSubscription = appFactory.CreateSubscription();
        Subscription callSubscription = callFactory.CreateSubscription();

        Console.WriteLine("Created Subscriptions:");
        Console.WriteLine(webSubscription);
        Console.WriteLine(appSubscription);
        Console.WriteLine(callSubscription);
    }
}
