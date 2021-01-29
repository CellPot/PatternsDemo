using Observer.Subject;
using UnityEngine;
using EventType = Observer.Subject.EventType;

namespace Observer.Objects
{
    public class MovementController : MonoBehaviour, IObserver
    {
        [SerializeField] private InputHandler inputHandler;
        private void Start()
        {
            inputHandler.Subject?.RegisterObserver(this);
        }

        private void OnDestroy()
        {
            inputHandler.Subject?.UnregisterObserver(this);
        }

        public void OnNotify(Object sender, EventType eventType)
        {
            switch (eventType)
            {
                case EventType.OnKeyDownMouse0:
                    Debug.Log("Player goes 1 point right");
                    break;
                case EventType.OnKeyDownMouse1:
                    Debug.Log("Player goes 1 point left");
                    break;
            }
        }
    }
}