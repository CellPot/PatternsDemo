using UnityEngine;

namespace FactoryMethod
{
    public class GenericFactory<T> : MonoBehaviour where T : MonoBehaviour
    {
        [SerializeField] private T prefab;

        public T GetNewInstance()
        {
            return Instantiate(prefab);
        }

        public T GetNewInstance(Vector3 position, Quaternion rotation)
        {
            return Instantiate(prefab, position, rotation);
        }
    }
}
