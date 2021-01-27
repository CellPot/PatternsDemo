using System.Collections;
using System.Collections.Generic;
using Builder.Builder;
using UnityEngine;

public class Tree 
{
    [SerializeField] private float x;
    [SerializeField] private float y;
    private TreeType _treeType;

    public Tree(TreeType type)
    {
        _treeType = type;
    }

    public void Draw()
    {
        _treeType.Draw(x,y);
    }

}

public class TreeType 
{
    public bool _material;
    
    public TreeType(bool material)
    {
        _material = material;
    }

    public void Draw(float x, float y)
    {
        Debug.Log($"Tree was drawn in {x} : {y}");
    }
    
}

public class Forest
{
    public List<Tree> Trees;

    public void PlantTree(float x, float y, bool material)
    {
        TreeType type = TreeFactory.GetTreeType(material);
        Tree newTree = 
    }
}

public class TreeFactory: MonoBehaviour
{
    public static List<TreeType> TreeTypes;

    public static TreeType GetTreeType(bool material)
    {
        TreeType type = TreeTypes.Find((x) => x._material = material);
        if (type == null)
        {
            type = new TreeType(material);
            TreeTypes.Add(type);
        }
        return type;
    }
    
}
