using UnityEngine;

namespace Flyweight
{
    public class SceneController : MonoBehaviour
    {
        //[SerializeField] private TreeFactory treeFactory;
        private Forest _forest;

        private void Awake()
        {
            _forest = new Forest();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                TreeType type0 = TreeFactory.GetTreeType(true);
                _forest.PushTree(1,2,type0.material);
            }
            else if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                _forest.DrawAllTrees();
            }
        }
    }
}