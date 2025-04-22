using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Runway
    {
        public Guid Id { get; } = Guid.NewGuid();
        public Aircraft? CurrentAircraft { get; private set; }

        public bool IsFree() => CurrentAircraft == null;

        public void Occupy(Aircraft aircraft)
        {
            CurrentAircraft = aircraft;
            Console.WriteLine($"Runway {Id} is now occupied by {aircraft.Name}.");
        }

        public void Release()
        {
            Console.WriteLine($"Runway {Id} is now free (released {CurrentAircraft?.Name}).");
            CurrentAircraft = null;
        }
    }
}
