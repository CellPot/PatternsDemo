using UnityEngine;

namespace FactoryMethod
{
    public class ObjectSpawner : MonoBehaviour
    {
        [SerializeField] private CubeFactory cubeFactory;
        [SerializeField] private EnemyFactory enemyFactory;
        [SerializeField] private int cubeAmount = 10;
        [SerializeField] private int enemyAmount = 10;
        [SerializeField] private bool spawnCubes;
        [SerializeField] private bool spawnEnemies;
        private int _cubeCount = 0;
        private int _enemyCount = 0;

        private void Update()
        {
            if (spawnCubes)
            {
                while (_cubeCount < cubeAmount)
                {
                    MonoBehaviour cube = cubeFactory.GetNewInstance();
                    cube.transform.SetPositionAndRotation(gameObject.transform.position,gameObject.transform.rotation);
                    _cubeCount++;
                }
                
            }
            if (spawnEnemies)
            {
                while (_enemyCount < enemyAmount)
                {
                    enemyFactory.GetNewInstance(gameObject.transform.position, gameObject.transform.rotation);
                    _enemyCount++;
                }
            }
        }
    }
}