using static System.Net.Mime.MediaTypeNames;
using System.Threading;
using Decorator;

namespace ConsoleApp_Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            IHero warrior = new Warrior();
            IHero mage = new Mage();
            IHero palladin = new Palladin();

            IHero buffedWarrior = new Sword(new Armor(new Artifact(warrior)));
            IHero buffedMage = new Artifact(new Artifact(new Mage()));
            IHero buffedPalladin = new Sword(new Sword(new Armor(palladin)));

            Console.WriteLine(buffedWarrior.GetDescription() + $" | Power: {buffedWarrior.GetPower()}");
            Console.WriteLine(buffedMage.GetDescription() + $" | Power: {buffedMage.GetPower()}");
            Console.WriteLine(buffedPalladin.GetDescription() + $" | Power: {buffedPalladin.GetPower()}");
        }
    }
}
