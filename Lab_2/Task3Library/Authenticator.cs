namespace Task3Library
{
    public sealed class Authenticator
    {
        private static readonly Lazy<Authenticator> instance =
            new Lazy<Authenticator>(() => new Authenticator(), LazyThreadSafetyMode.ExecutionAndPublication);

        private Authenticator() { }

        public static Authenticator Instance => instance.Value;

        public void Authenticate(string user)
        {
            Console.WriteLine($"User {user} authenticated. Instance ID: {GetHashCode()}");
        }
    }
}