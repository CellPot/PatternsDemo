using System;
using UnityEngine;

namespace Builder.Product
{
    public abstract class Laser : MonoBehaviour
    {
        private void Awake()
        {
            Debug.Log("Laser created",this);
        }

        public abstract void Shoot();
    }
}