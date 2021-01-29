using Observer.Subject;
using UnityEngine;
using EventType = Observer.Subject.EventType;

namespace Observer.Objects
{
    public class AchievementsController : MonoBehaviour, IObserver
    {
        [SerializeField] private InputHandler inputHandler;
        private bool _isUnlocked = false;
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
            if (_isUnlocked) return;
            GiveAchievement(eventType);
        }
        private void GiveAchievement(EventType eventType)
        {
            switch (eventType)
            {
                case EventType.OnKeyDownMouse0:
                case EventType.OnKeyDownMouse1:
                case EventType.OnKeyMouse0:
                case EventType.OnKeyMouse1:
                    Debug.Log("Achievement unlocked! Player did something!");
                    _isUnlocked = true;
                    break;
            }
        }
    }
}