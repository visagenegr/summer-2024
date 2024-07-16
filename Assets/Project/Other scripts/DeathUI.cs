using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeathUI : MonoBehaviour
{
  public GameObject deathScreen; // UI экран при смерти
    public TMP_Text healthText; // Текст для отображения HP игрока
    private Health playerHealth; // Ссылка на компонент Health игрока

    void Start()
    {
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            playerHealth = player.GetComponent<Health>();
            playerHealth.deathUI = this; // Устанавливаем ссылку на DeathUI
        }
        else
        {
            Debug.LogError("Player object not found!");
        }
    }

    void Update()
    {
        if (playerHealth != null)
        {
            healthText.text = "HP: " + playerHealth.currentHealth.ToString();
            Debug.Log("Current Health: " + playerHealth.currentHealth);

            if (playerHealth.currentHealth <= 0 && !deathScreen.activeSelf)
            {
                ShowDeathScreen();
            }
        }
    }

    public void ShowDeathScreen()
    {
        Debug.Log("Showing Death Screen");
        healthText.gameObject.SetActive(false);
        deathScreen.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
