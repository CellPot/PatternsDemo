using System;
using System.ComponentModel;
using UnityEngine;

namespace Builder.Product
{
    public class Ship : MonoBehaviour
    {
        public Laser laser;
        public int thrustersAmount;
        public float scanDistance;

        private void Awake()
        {
            Debug.Log("Ship created",this.gameObject);
        }

        public void Shoot()
        {
            laser.Shoot();
        }

        public void Move(float speed)
        {
            Debug.Log($"Moved to {(speed * thrustersAmount).ToString()} points",this.gameObject);
        }

        public void Scan()
        {
            Debug.Log($"Scanned {(scanDistance).ToString()} points", this.gameObject);
        }
    }
}