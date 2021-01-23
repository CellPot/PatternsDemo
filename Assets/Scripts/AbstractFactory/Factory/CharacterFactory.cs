using System;
using AbstractFactory.Product;
using UnityEngine;

namespace AbstractFactory.Factory
{
    public abstract class CharacterFactory : MonoBehaviour
    {
        protected Weapon WeaponPref;
        protected Skill SkillPref;

        public virtual Skill AddSkill(Transform placeholder)
        {
            return Instantiate(SkillPref,placeholder.position,placeholder.rotation,placeholder);
        }

        public virtual Weapon AddWeapon(Transform placeholder)
        {
            return Instantiate(WeaponPref,placeholder.position,placeholder.rotation,placeholder);
        }
    }
}