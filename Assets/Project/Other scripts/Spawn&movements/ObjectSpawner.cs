using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
     public GameObject objectToSpawn; // Объект, который будет создаваться
    public float spawnInterval = 2.0f; // Интервал между созданиями объектов в секундах

    private void Start()
    {
        StartCoroutine(SpawnObjects());
    }

    private IEnumerator SpawnObjects()
    {
        while (true)
        {
            Instantiate(objectToSpawn, transform.position, transform.rotation);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}