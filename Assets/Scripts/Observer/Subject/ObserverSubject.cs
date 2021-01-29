using System.Collections.Generic;
using Observer.Objects;
using UnityEngine;

namespace Observer.Subject
{
    public class ObserverSubject
    {
        private List<IObserver> _observers;
        private readonly Object _sender;
        public ObserverSubject(Object sender)
        {
            _observers = new List<IObserver>();
            _sender = sender;
        }
        public void RegisterObserver(IObserver observer)
        {
            if (_observers.Contains(observer) == false)
                _observers.Add(observer);
        }
        public void UnregisterObserver(IObserver observer)
        {
            if (_observers.Contains(observer) == true)
                _observers.Remove(observer);
        }
        public void UnregisterAllObservers()
        {
            foreach (var observer in _observers)
            {
                UnregisterObserver(observer);
            }
        }
        public void NotifyObservers(EventType eventType)
        {
            foreach (var observer in _observers)
            {
                observer.OnNotify(_sender, eventType);
            }
        }
        
    }
}