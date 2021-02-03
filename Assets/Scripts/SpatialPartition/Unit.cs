using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
   private Vector2 _initPosition;

   private void Awake()
   {
      _initPosition = gameObject.transform.position;
   }

   public void Move(Vector2 positionDelta)
   {
      
   }
}

public class Grid
{
   public int CellsNum = 10;
   public int CellSize = 20;

   private Unit[,] _cells;

   public Grid()
   {
      _cells  = new Unit[CellsNum, CellsNum];
   }
   
   public void Clear()
   {
      for (int i = 0; i < CellsNum; i++)
      {
         for (int j = 0; j < CellsNum; j++)
         {
            _cells[i, j] = null;
         }
      }
   }
}
