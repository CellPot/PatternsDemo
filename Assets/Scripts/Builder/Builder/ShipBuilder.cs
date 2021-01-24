using Builder.Product;
using UnityEngine;

namespace Builder.Builder
{
    public class ShipBuilder : MonoBehaviour, IShipBuilder
    {
        [SerializeField] private Ship ship;
        [SerializeField] private Laser laser;
        [SerializeField] private float scannerDistance;
        [SerializeField] private int thrustersAmount;
        
        public void SetThrusters()
        {
            ship.thrustersAmount = thrustersAmount;
        }
        public void SetLaser()
        {
            ship.laser = laser;
        }
        public void SetScanner()
        {
            ship.scanDistance = scannerDistance;
        }
        public Ship GetResult()
        {
            Ship newShip = Instantiate(ship);
            Instantiate(ship.laser,newShip.transform.position,newShip.transform.rotation,newShip.transform);
            return newShip;
        }
    }
}