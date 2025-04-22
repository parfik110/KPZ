using Mediator;

namespace Mediator
{
    public class ControlTower : IControlTower
    {
        private readonly List<Runway> runways = new();
        private readonly List<Aircraft> aircrafts = new();

        public void RegisterRunway(Runway runway) => runways.Add(runway);
        public void RegisterAircraft(Aircraft aircraft) => aircrafts.Add(aircraft);

        public void RequestLanding(Aircraft aircraft)
        {
            foreach (var runway in runways)
            {
                if (runway.IsFree())
                {
                    Console.WriteLine($"ControlTower: {aircraft.Name} landing approved.");
                    runway.Occupy(aircraft);
                    return;
                }
            }
            Console.WriteLine($"ControlTower: No available runway for {aircraft.Name}.");
        }

        public void RequestTakeoff(Aircraft aircraft)
        {
            foreach (var runway in runways)
            {
                if (runway.CurrentAircraft == aircraft)
                {
                    Console.WriteLine($"ControlTower: {aircraft.Name} takeoff approved.");
                    runway.Release();
                    return;
                }
            }
            Console.WriteLine($"ControlTower: {aircraft.Name} is not on any runway.");
        }
    }
}
