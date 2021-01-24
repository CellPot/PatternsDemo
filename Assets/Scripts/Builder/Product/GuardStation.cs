using UnityEngine;

namespace Builder.Product
{
    public class GuardStation : MonoBehaviour
    {
        public Laser laser;
        public float scanDistance;

        private void Awake()
        {
            Debug.Log("Station created",this.gameObject);
        }

        public void Shoot()
        {
            laser.Shoot();
        }
        public void Scan()
        {
            Debug.Log($"Scanned {(scanDistance).ToString()} points", this.gameObject);
        }
    }
}