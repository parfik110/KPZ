using Proksi;

namespace ConsoleApp_Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            string testFile = "test.txt";
            File.WriteAllText(testFile, "Hello\nWorld!");

            Console.WriteLine("=== Звичайне читання з логуванням ===");
            ISmartTextReader checker = new SmartTextChecker();
            checker.ReadFile(testFile);

            Console.WriteLine("\n=== Читання з обмеженням доступу ===");
            ISmartTextReader locker = new SmartTextReaderLocker(@"^.*secret.*\.txt$");
            locker.ReadFile("secret.txt");
            char[][] result = locker.ReadFile("test.txt");  
            if (result != null)
            {
                Console.WriteLine("[LOCKER] File content:");
                foreach (var line in result)
                    Console.WriteLine(new string(line));
            }
        }
    }
}
