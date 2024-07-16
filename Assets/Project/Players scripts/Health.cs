using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
   public int maxHealth = 100; // Максимальное количество здоровья
    public int currentHealth;
    public CameraFollow cameraFollow;
    public DeathUI deathUI; // Ссылка на компонент DeathUI

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void Heal(int amount)
    {
        currentHealth += amount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    private void Die()
    {
        if (cameraFollow != null)
        {
            cameraFollow.OnTargetDeath();
        }

        if (deathUI != null)
        {
            deathUI.ShowDeathScreen();
        }

        foreach (MonoBehaviour script in GetComponents<MonoBehaviour>())
        {
            script.enabled = false;
        }

        Destroy(gameObject);
    }
}
