using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class Health : MonoBehaviour
{
    public int healthpoints;
    
    public float Resistance;
    public GameObject player;
    public void TakeDamage(int damage){
        //some logic
        Destroy(player);
    }
    


}

