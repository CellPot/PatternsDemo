using UnityEngine;

namespace CommandPattern
{
    public class MovementController : MonoBehaviour
    {
        [SerializeField] private Player player;
        private Transform _playerTransform;
        private void Awake()
        {
            _playerTransform = player.transform;
        }
        public void Move(float x, float y)
        {
            Vector3 positionDelta = new Vector3(x,y,0f);
            _playerTransform.Translate(positionDelta);
            Debug.Log("Player moved!");
        }
    }
}