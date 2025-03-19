namespace SubscriptionLibrary
{
    public abstract class Subscription
    {
        public abstract string Name { get; }
        public abstract decimal MonthlyFee { get; }
        public abstract int MinSubscriptionPeriod { get; }
        public abstract List<string> Channels { get; }
        public abstract List<string> Features { get; }

        public override string ToString()
        {
            return $"{Name} - ${MonthlyFee} per month, Min period: {MinSubscriptionPeriod} months\nChannels: {string.Join(", ", Channels)}\nFeatures: {string.Join(", ", Features)}";
        }
    }
}