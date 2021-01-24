using System;
using Builder.Builder;
using Builder.Product;
using UnityEngine;

namespace Builder
{
    public class SceneController : MonoBehaviour
    {
        [SerializeField] private Director director;
        [SerializeField] private ShipBuilder battleShipBuilder;
        [SerializeField] private ShipBuilder reconShipBuilder;
        [SerializeField] private StationBuilder battleStationBuilder;
        private Ship _ship;

        private void Awake()
        {
            director.ConstructBattleStation(battleStationBuilder);
            battleStationBuilder.GetResult();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                director.ConstructShip(battleShipBuilder);
                _ship = battleShipBuilder.GetResult();
            }
            else if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                _ship.Shoot();
                _ship.Scan();
                _ship.Move(2f);
            }
            else if (Input.GetKeyDown(KeyCode.Mouse2))
            {
                director.ConstructShip(reconShipBuilder);
                _ship = reconShipBuilder.GetResult();
            }
        }
        
    }
}