using UnityEngine;

namespace AbstractFactory.Product
{
    public class Mace : Weapon
    {
        public override void Hit()
        {
            Debug.Log("Mace hit");
        }
    }
}