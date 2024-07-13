using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StompAttack : Basicattack
{
   public override void DoAttack()
   {
       base.DoAttack();
       Debug.Log("Also Stomped");

   }
}
