using System;
using UnityEngine;

namespace Flyweight
{
    public class Weapon : MonoBehaviour
    {
        [SerializeField] private WeaponData data;
        [SerializeField] private float damage;
        
        public void DoSomething()
        {
            Debug.Log($"{data.WeaponName} does something");
        }
    }
}