using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    public Attack attack;
    void Start(){
        attack.GetEnemies(3.0f);
        attack.DoAttack();
    }
}
