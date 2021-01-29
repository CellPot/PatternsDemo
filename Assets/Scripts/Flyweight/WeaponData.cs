using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Flyweight
{
    [CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/WeaponData", order = 1)]
    public class WeaponData : ScriptableObject
    {
        [SerializeField] private string weaponName;
        [SerializeField] private string weaponDescription;
        [SerializeField] private string weaponOtherParam;

        public string WeaponName => weaponName;
        public string WeaponDescription => weaponDescription;
        public string WeaponOtherParam => weaponOtherParam;
    }
}