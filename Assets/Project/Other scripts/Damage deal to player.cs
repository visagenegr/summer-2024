using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damagedealtoplayer : MonoBehaviour
{
     public int damageAmount = 10; //урон по игроку

    private void OnCollisionEnter(Collision collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();
        if (player != null)
        {
            player.health.TakeDamage(damageAmount);
        }
    }
}
