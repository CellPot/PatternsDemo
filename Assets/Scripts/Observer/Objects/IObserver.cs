using UnityEngine;
using EventType = Observer.Subject.EventType;

namespace Observer.Objects
{
    public interface IObserver
    {
        void OnNotify(Object sender, EventType eventType);
    }
}