using AbstractFactory.Product;
using UnityEngine;

namespace AbstractFactory.Factory
{
    public class WarriorFactory : CharacterFactory
    {
        [SerializeField] private Sword weaponPref;
        [SerializeField] private FireConeSkill skillPref;
        private void Awake()
        {
            base.WeaponPref = this.weaponPref;
            base.SkillPref = this.skillPref;
        }
    }
}