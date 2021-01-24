using UnityEngine;

namespace Builder.Product
{
    public class ImpulseLaser : Laser
    {
        public override void Shoot()
        {
            Debug.Log("Impulse laser shot", this.gameObject);
        }
    }
}