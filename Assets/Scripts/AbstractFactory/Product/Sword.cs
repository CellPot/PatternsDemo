using UnityEngine;

namespace AbstractFactory.Product
{
    public class Sword : Weapon
    {
        public override void Hit()
        {
            Debug.Log("Sword hit");
        }
    }
}