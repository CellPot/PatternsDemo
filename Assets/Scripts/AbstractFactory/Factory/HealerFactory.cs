using System;
using UnityEngine;
using AbstractFactory.Product;

namespace AbstractFactory.Factory
{
    public class HealerFactory : CharacterFactory
    {
        [SerializeField] private Mace weaponPref;
        [SerializeField] private HealSkill skillPref;

        private void Awake()
        {
            base.WeaponPref = this.weaponPref;
            base.SkillPref = this.skillPref;
        }
    }
}