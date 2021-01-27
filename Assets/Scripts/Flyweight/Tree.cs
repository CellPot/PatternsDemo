using System.Collections;
using System.Collections.Generic;
using Builder.Builder;
using UnityEngine;

public class Tree : MonoBehaviour
{
    [SerializeField] private float x;
    [SerializeField] private float y;
    private TreeType _treeType;

    public void Draw()
    {
        _treeType.Draw(x,y);
    }

}

public class TreeType 
{
    public Material _material;
    
    public TreeType(Material material)
    {
        _material = material;
    }

    public void Draw(float x, float y)
    {
        Debug.Log($"Tree was drawn in {x.ToString()} : {y.ToString()}");
    }
    
}

public class Forest
{
    public List<Tree> Trees;

    public void PlantTree(float x, float y, Material material)
    {
        TreeType type = TreeFactory.GetTreeType(material);
    }
}

public class TreeFactory: MonoBehaviour
{
    public static List<TreeType> TreeTypes;

    public static TreeType GetTreeType(Material material)
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
