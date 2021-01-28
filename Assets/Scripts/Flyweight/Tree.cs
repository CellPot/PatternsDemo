using UnityEngine;

namespace Flyweight
{
    public class Tree 
    {
        [SerializeField] private float x;
        [SerializeField] private float y;
        private TreeType _treeType;

        public Tree(TreeType type, float x, float y)
        {
            _treeType = type;
            this.x = x;
            this.y = y;
            Debug.Log($"New tree was created with mat = {_treeType.material}");
        }

        public void Draw()
        {
            Debug.Log($"Tree's Draw sent to TreeType from Tree");
            _treeType.Draw(x,y);
        }

    }
}