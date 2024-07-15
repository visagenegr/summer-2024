using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
   public int maxHealth = 100; // Максимальное количество здоровья
    private int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth; // Устанавливаем текущее здоровье на максимальное при старте
    }

    // Метод для нанесения урона
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    // Метод для восстановления здоровья
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
        Debug.Log("Player died");
        Destroy(gameObject);
    }
    void FixedUpdate()
    {
        Debug.Log(currentHealth);
    }
}
