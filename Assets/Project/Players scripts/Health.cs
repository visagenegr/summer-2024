using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100; // Максимальное количество здоровья
    public int currentHealth;
    public CameraFollow cameraFollow;
    public GameObject deathPanel; // Панель смерти из Canvas
    public GameObject explosionEffect; // Префаб партикла взрыва

    private void Start()
    {
        currentHealth = maxHealth;
        if (deathPanel != null)
        {
            deathPanel.SetActive(false); // Отключаем панель смерти по умолчанию
        }
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
        Instantiate(explosionEffect, transform.position, transform.rotation);

        if (cameraFollow != null)
        {
            cameraFollow.OnTargetDeath();
        }

        if (deathPanel != null)
        {
            deathPanel.SetActive(true); // Включаем панель смерти
        }

        foreach (MonoBehaviour script in GetComponents<MonoBehaviour>())
        {
            script.enabled = false;
        }

        Destroy(gameObject);
    }
}
