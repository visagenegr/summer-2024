using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketSpawner : MonoBehaviour
{
     public GameObject rocketPrefab; 
    public Transform spawnPoint; 
    public float cooldownTime = 5.0f; 
    private bool isCooldown = false; 
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isCooldown)
        {
            SpawnRocket();
        }
    }

    void SpawnRocket()
    {
        Instantiate(rocketPrefab, spawnPoint.position, spawnPoint.rotation);
        StartCoroutine(Cooldown());
    }
 
    IEnumerator Cooldown()
    {
        isCooldown = true;
        yield return new WaitForSeconds(cooldownTime);
        isCooldown = false;
    }
}
