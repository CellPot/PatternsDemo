using UnityEngine;

namespace CommandPattern
{
    public class Player : MonoBehaviour
    {
        public int FireCount { get; private set; } = 0;
        public void Fire()
        {
            FireCount++;
            Debug.Log($"Player fired {FireCount.ToString()} times");
        }
        public void UnFire()
        {
            FireCount--;
            Debug.Log($"Somehow unfired! Total fires: {FireCount.ToString()}");
        }
        
    }
}