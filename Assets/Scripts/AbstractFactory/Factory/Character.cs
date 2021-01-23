using System;
using AbstractFactory.Product;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AbstractFactory.Factory
{
    public abstract class Character : MonoBehaviour
    {
        [SerializeField] private Transform weaponPlaceholder;
        [SerializeField] private Transform skillPlaceholder;
        protected CharacterFactory Factory;
        private Weapon _weapon;
        private Skill _skill;

        public virtual void Start()
        {
            _weapon = Factory.AddWeapon(weaponPlaceholder);
            _skill = Factory.AddSkill(skillPlaceholder);
        }

        public void Hit()
        {
            _weapon.Hit();
        }

        public void Cast()
        {
            _skill.Cast();
        }
    }
}