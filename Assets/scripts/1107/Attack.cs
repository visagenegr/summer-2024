using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Attack : MonoBehaviour
{
    public abstract void DoAttack();
 
    public abstract void GetEnemies(float range);  
}
