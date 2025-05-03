using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class EventManager
    {
        private readonly Dictionary<string, List<Action>> _eventHandlers = new();

        public void Subscribe(string eventType, Action handler)
        {
            if (!_eventHandlers.ContainsKey(eventType))
                _eventHandlers[eventType] = new List<Action>();

            _eventHandlers[eventType].Add(handler);
        }

        public void Trigger(string eventType)
        {
            if (_eventHandlers.ContainsKey(eventType))
            {
                foreach (var handler in _eventHandlers[eventType])
                {
                    handler.Invoke();
                }
            }
        }
    }
}
