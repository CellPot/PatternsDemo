using UnityEngine;

namespace Builder.Product
{
    public class IonicLaser : Laser
    {
        public override void Shoot()
        {
            Debug.Log("Ionic laser shot", this.gameObject);
        }
    }
}