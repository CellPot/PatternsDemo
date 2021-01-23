using UnityEngine;

namespace AbstractFactory.Product
{
    public class FireConeSkill : Skill
    {
        public override void Cast()
        {
            Debug.Log("Fire Cone");
        }
    }
}