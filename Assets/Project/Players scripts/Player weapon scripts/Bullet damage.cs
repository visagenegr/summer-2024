using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletdamage : MonoBehaviour
{
   
        public int damage = 10; // Урон, наносимый пулей

        private void OnCollisionEnter(Collision collision)
     {
         EnemyHealth enemy = collision.gameObject.GetComponent<EnemyHealth>();
            if (enemy != null)
          {
            enemy.TakeDamage(damage);
          }
            Destroy(gameObject); 
     }
}


