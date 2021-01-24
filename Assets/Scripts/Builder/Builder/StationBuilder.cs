using Builder.Product;
using UnityEngine;

namespace Builder.Builder
{
    public class StationBuilder : MonoBehaviour, IShipBuilder
    {
        [SerializeField] private GuardStation station;
        [SerializeField] private Laser laser;
        [SerializeField] private float scannerDistance;
        public void SetThrusters()
        {
            Debug.Log("No thrusters were set",this.gameObject);
        }
        public void SetLaser()
        {
            station.laser = laser;
        }
        public void SetScanner()
        {
            station.scanDistance = scannerDistance;
        }
        public GuardStation GetResult()
        {
            GuardStation newStation = Instantiate(station);
            Instantiate(newStation.laser,newStation.transform.position,newStation.transform.rotation,newStation.transform);
            return newStation;
        }
    }
}