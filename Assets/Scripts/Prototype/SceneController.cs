using UnityEngine;

namespace Prototype
{
    public class SceneController : MonoBehaviour
    {
        [SerializeField] private bool isBeeTalkative;
        [SerializeField] private bool isWolfAgressive;
        [SerializeField] private int wolfAbilitiesNumber;

        private Enemy enemy1;
        private Enemy enemy2;

        private void Awake()
        {
            enemy1 = new Bee(isBeeTalkative);
            Debug.Log(enemy1.GetDescription());
            enemy2 = new Wolf(isWolfAgressive, wolfAbilitiesNumber);
            Debug.Log(enemy2.GetDescription());
        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Enemy clonedEnemy = enemy1.Clone();
                Debug.Log(clonedEnemy.GetDescription());
            }
            else if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                Enemy clonedEnemy = enemy2.Clone();
                Debug.Log(clonedEnemy.GetDescription());
            }
        }

    }

}



