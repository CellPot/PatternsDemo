using UnityEngine;

namespace Singleton
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static bool _shuttingDown = false;
        private static T _instance;

        protected virtual void Awake()
        {
            if (_instance == null)
            {
                _instance = this.GetComponent<T>();
                Debug.Log($"Singleton instance '{ typeof(T) }' is initialised", gameObject);
            }
            else
            {
                Debug.Log($"Singleton instance '{ typeof(T) }' already exists. Destroying attached to this one", gameObject);
                Destroy(gameObject.GetComponent<T>());
            }
        }

        public static T Instance
        {
            get
            {
                if (_shuttingDown)
                {
                    Debug.LogWarning($"Singleton instance '{ typeof(T) }' already destroyed. Returning null.");
                    return null;
                }
                if (_instance == null)
                {                
                    _instance = (T)FindObjectOfType(typeof(T));
                    if (_instance == null)
                    {
                        _instance = GetNewInstance();
                    }
                }
                return _instance;
            }
        }
        private static T GetNewInstance()
        {
            Debug.Log($"Singleton instance '{ typeof(T) }' wasn't found and being created.");
            var singletonObject = new GameObject();
            singletonObject.name = typeof(T).ToString() + " (Singleton)";
            //DontDestroyOnLoad(singletonObject);
            var newInstance = singletonObject.AddComponent<T>();
            return newInstance;
        }
        private void OnApplicationQuit()
        {
            _shuttingDown = true;
        }
    }
}
