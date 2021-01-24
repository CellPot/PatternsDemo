using Builder.Product;
using UnityEngine;

namespace Builder.Builder
{
    public class Director : MonoBehaviour
    {
        private IShipBuilder _builder;


        public void ConstructShip(IShipBuilder builder)
        {
            builder.SetLaser();
            builder.SetScanner();
            builder.SetThrusters();
        }

        public void ConstructBattleStation(IShipBuilder builder)
        {
            builder.SetLaser();
            builder.SetScanner();
        }
        
    }
}