using Adapter;

namespace ConsoleApp_Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            ILogger consoleLogger = new ConsoleLogger();
            consoleLogger.Log("Консоль: інформаційне повідомлення");
            consoleLogger.Error("Консоль: помилка");
            consoleLogger.Warn("Консоль: попередження");

            ILogger fileLogger = new FileLoggerAdapter("log.txt");
            fileLogger.Log("Файл: інформація");
            fileLogger.Error("Файл: помилка");
            fileLogger.Warn("Файл: попередження");

            Console.WriteLine("Адаптер працює. Перевір файл log.txt.");
        }
    }
}
