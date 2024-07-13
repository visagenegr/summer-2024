using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basicattack : Attack
{
   public override void DoAttack()
   {
        Debug.Log("Atack in line");

   }
    public override void GetEnemies(float range)
    {
        Debug.Log("Got enemies in line");

    }
}
