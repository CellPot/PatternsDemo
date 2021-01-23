using UnityEngine;

namespace AbstractFactory.Product
{
    public class HealSkill : Skill
    {
        public override void Cast()
        {
            Debug.Log("Healing");
        }
    }
}