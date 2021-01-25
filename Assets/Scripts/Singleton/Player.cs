using UnityEngine;

namespace Singleton
{
    public class Player : MonoBehaviour
    {

        [SerializeField] private float health;

        public float Health { get => health; }


    }
}
