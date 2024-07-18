using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeathUI : MonoBehaviour
{
 public GameObject deathPanel;
    public TMP_Text healthText;
    private Health playerHealth;

    void Start()
    {
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            playerHealth = player.GetComponent<Health>();
            playerHealth.deathPanel = deathPanel;
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

            if (playerHealth.currentHealth <= 0 && !deathPanel.activeSelf)
            {
                ShowDeathPanel();
            }
        }
    }

    public void ShowDeathPanel()
    {
        Debug.Log("Showing Death Panel");
        healthText.gameObject.SetActive(false);
        deathPanel.SetActive(true);
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
