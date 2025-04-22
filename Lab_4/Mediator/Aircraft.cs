using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Aircraft
    {
        public string Name { get; }
        private readonly IControlTower tower;

        public Aircraft(string name, IControlTower tower)
        {
            Name = name;
            this.tower = tower;
        }

        public void RequestLanding()
        {
            Console.WriteLine($"{Name} requesting landing...");
            tower.RequestLanding(this);
        }

        public void RequestTakeoff()
        {
            Console.WriteLine($"{Name} requesting takeoff...");
            tower.RequestTakeoff(this);
        }
    }
}
