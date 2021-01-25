using UnityEngine;

namespace Singleton
{
    public class PlayerManager : Singleton<PlayerManager>
    {

        [SerializeField] Player player;

        protected PlayerManager() { }

        protected override void Awake()
        {
            base.Awake();
            if (player == null)
            {
                player = (Player)FindObjectOfType(typeof(Player));
            }
        
        }

        public string GetPlayerStatus()
        {
            return $"Player's health: {player?.Health}";
        }
    }
}
