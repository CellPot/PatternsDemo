using System;
using System.Collections;
using UnityEngine;

namespace Flyweight
{
    public class SceneController : MonoBehaviour
    {
        [SerializeField] private Weapon weapon0;
        [SerializeField] private Weapon weapon1;
        [SerializeField] private int weaponAmount;
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                StartCoroutine(WeaponCreateCoroutine(weapon0));
            }
            else if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                StartCoroutine(WeaponCreateCoroutine(weapon1));
            }
        }
        private IEnumerator WeaponCreateCoroutine(Weapon weapon)
        {
            for (int i = 0; i < weaponAmount; i++)
            {
                Instantiate(weapon);
            }
            yield return null;
        }
    }
}