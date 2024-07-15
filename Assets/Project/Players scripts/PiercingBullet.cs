using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiercingBullet : MonoBehaviour
{
     public int damage = 10; // Урон, наносимый пулей

    private void OnTriggerEnter(Collider other)
    {
        // Проверяем, столкнулась ли пуля с врагом
        if (other.CompareTag("Enemy"))
        {
            // Получаем компонент здоровья врага и наносим урон
            EnemyHealth enemyHealth = other.GetComponent<EnemyHealth>();
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(damage);
            }
        }
    }
}
