using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace AbstractFactory.Factory
{
    public class CharacterController : MonoBehaviour
    {
        [SerializeField] private Character character;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                character.Hit();
            }
            else if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                character.Cast();
            }
        }
    }
}