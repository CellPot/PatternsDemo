using System;
using UnityEngine;

namespace Observer.Subject
{
    public class InputHandler : MonoBehaviour
    {
        public ObserverSubject Subject;
        private void Awake()
        {
            Subject = new ObserverSubject(this);
        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
                Subject.NotifyObservers(EventType.OnKeyDownMouse0);
            else if (Input.GetKeyDown(KeyCode.Mouse1))
                Subject.NotifyObservers(EventType.OnKeyDownMouse1);
        }
        private void OnDestroy()
        {
            Subject.UnregisterAllObservers();
        }
    }
    public enum EventType
    {
        OnKeyDownMouse0,
        OnKeyDownMouse1,
        OnKeyMouse0,
        OnKeyMouse1
    }
}