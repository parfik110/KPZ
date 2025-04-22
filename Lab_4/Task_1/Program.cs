using Handlers;

namespace Task_1
{
    public class Program
    {
        static void Main()
        {
            var billing = new BillingSupport();
            var tech = new TechSupport();
            var account = new AccountSupport();
            var general = new GeneralSupport();

            billing.SetNext(tech);
            tech.SetNext(account);
            account.SetNext(general);

            while (true)
            {
                Console.WriteLine("📞 Вітаємо у системі підтримки!");
                Console.WriteLine("Виберіть тип проблеми (billing / tech / account / general):");
                string? issue = Console.ReadLine()?.Trim().ToLower();

                if (!billing.Handle(issue ?? ""))
                {
                    Console.WriteLine("❌ Не знайдено відповідного оператора. Спробуйте ще раз.");
                }

                Console.WriteLine("Бажаєте продовжити? (y/n)");
                if ((Console.ReadLine()?.Trim().ToLower()) != "y")
                    break;
            }

            Console.WriteLine("👋 Дякуємо за звернення!");
        }
    }
}
