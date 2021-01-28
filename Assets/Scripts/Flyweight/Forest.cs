using System.Collections.Generic;
using UnityEngine;

namespace Flyweight
{
    public class Forest
    {
        public List<Tree> Trees = new List<Tree>();

        public void PushTree(float x, float y, bool material)
        {
            TreeType type = TreeFactory.GetTreeType(material);
            Tree newTree = new Tree(type,x,y);
            Trees.Add(newTree);
            Debug.Log($"Tree with mat = {type.material.ToString()} was pushed into forest");
        }
        public void DrawAllTrees()
        {
            foreach (Tree t in Trees)
            {
                t.Draw();
            }
            Debug.Log($"Trees were drawn: {Trees.Count.ToString()}");
        }
    }
}