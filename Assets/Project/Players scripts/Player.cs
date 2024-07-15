using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Health health; 
    public int healAmountPerSecond = 5; // хп в секунду
    
    public static Player playerInstance;

    void OnEnable(){
        if (playerInstance == null) {
            Player.playerInstance = this;
        }

    }
    private void Start()
    {
        StartCoroutine(AutoHeal());
    }

    private IEnumerator AutoHeal()
    {
        while (true)
        {
            health.Heal(healAmountPerSecond);
            yield return new WaitForSeconds(1.0f); //  1 секунда перед следующим хп рефилом
        }
    }
}
