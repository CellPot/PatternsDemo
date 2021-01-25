using UnityEngine;

namespace Singleton
{
    public class SceneController : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                var playerStatus = PlayerManager.Instance.GetPlayerStatus();
                Debug.Log(playerStatus);
            }
        }
    }
}
