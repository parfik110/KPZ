using System.Reflection.Emit;
using Task5Library;

class Program
{
    static void Main()
    {
        CharacterDirector director = new CharacterDirector();
        Character hero = director.CreateHero(new HeroBuilder());
        Character enemy = director.CreateEnemy(new EnemyBuilder());

        Console.WriteLine("Hero:");
        hero.ShowInfo();

        Console.WriteLine("Enemy:");
        enemy.ShowInfo();
    }
}