using Mediator;
namespace Task_2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("\n--- Посередник ---");

            var tower = new ControlTower();

            var runway1 = new Runway();
            var runway2 = new Runway();

            var plane1 = new Aircraft("Boeing 737", tower);
            var plane2 = new Aircraft("Airbus A320", tower);

            tower.RegisterRunway(runway1);
            tower.RegisterRunway(runway2);
            tower.RegisterAircraft(plane1);
            tower.RegisterAircraft(plane2);

            plane1.RequestLanding();
            plane2.RequestLanding();

            plane1.RequestTakeoff();
            plane2.RequestTakeoff();
        }
    }
}
