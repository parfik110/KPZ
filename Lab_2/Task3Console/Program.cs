using Task3Library;

class Program
{
    static void Main()
    {
        Thread thread1 = new Thread(() =>
        {
            var auth1 = Authenticator.Instance;
            auth1.Authenticate("Alice");
        });

        Thread thread2 = new Thread(() =>
        {
            var auth2 = Authenticator.Instance;
            auth2.Authenticate("Bob");
        });

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();
    }
}
