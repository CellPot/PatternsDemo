using UnityEngine;
using UnityEngine.Serialization;

namespace Flyweight
{
    public class TreeType 
    {
        public bool material;
    
        public TreeType(bool material)
        {
            this.material = material;
            Debug.Log($"TreeType is created with mat = {this.material}");
        }

        public void Draw(float x, float y)
        {
            Debug.Log($"TreeType was drawn in {x} : {y}, it's material = {material.ToString()}");
        }
    
    }
}