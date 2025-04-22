using Mediator;

namespace Mediator
{
    public interface IControlTower
    {
        void RequestLanding(Aircraft aircraft);
        void RequestTakeoff(Aircraft aircraft);
    }
}
