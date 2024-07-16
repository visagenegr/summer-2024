using System.Collections;
using System.Collections.Generic;
using TMPro;
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
        playerHealth = GameObject.FindWithTag("Player").GetComponent<Health>();
    }

    void Update()
    {
        healthText.text = "HP: " + playerHealth.currentHealth.ToString();

        if (playerHealth.currentHealth <= 0)
        {
            ShowDeathScreen();
        }
    }

    public void ShowDeathScreen()
    {
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
