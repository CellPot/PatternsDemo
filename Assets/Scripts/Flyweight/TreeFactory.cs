using System;
using System.Collections.Generic;
using UnityEngine;

namespace Flyweight
{
    public class TreeFactory
    {
        public static List<TreeType> TreeTypes = new List<TreeType>();


        public static TreeType GetTreeType(bool material)
        {
            TreeType type = TreeTypes.Find((x) => x.material = material);
            if (type == null)
            {
                type = new TreeType(material);
                Debug.Log("TreeType is being instantiated in factory");
                //type = new TreeType(material);
                TreeTypes.Add(type);
            }
            return type;
        }
    }
}