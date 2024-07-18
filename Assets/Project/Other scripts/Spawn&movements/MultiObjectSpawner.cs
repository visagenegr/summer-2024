using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiObjectSpawne : MonoBehaviour
{ 
    public GameObject[] objectsToSpawn;
    public int numberOfRows = 3;
    public int numberOfObjectsPerRow = 10;
    public float rowSpacing = 2.0f; 
    public float objectSpacing = 2.0f;
    public Vector3 direction = Vector3.forward; 
    public float speed = 1.0f; 
    public Transform player;
    public float activationDistance = 10.0f;

    private List<GameObject> spawnedObjects = new List<GameObject>();
    private bool isActive = false;

    void Update()
    {
        if (player == null)
        {
            return; 
        }

        if (!isActive && Vector3.Distance(transform.position, player.position) <= activationDistance)
        {
            isActive = true;
            SpawnObjects();
        }

        if (isActive)
        {
            MoveObjects();
        }
    }

    void SpawnObjects()
    {
        for (int row = 0; row < numberOfRows; row++)
        {
            for (int i = 0; i < numberOfObjectsPerRow; i++)
            {
                GameObject objectToSpawn = objectsToSpawn[Random.Range(0, objectsToSpawn.Length)];
                Vector3 spawnPosition = transform.position + row * rowSpacing * Vector3.forward + i * objectSpacing * Vector3.right;
                GameObject spawnedObject = Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
                spawnedObjects.Add(spawnedObject);
            }
        }
    }

    void MoveObjects()
    {
        for (int i = spawnedObjects.Count - 1; i >= 0; i--)
        {
            if (spawnedObjects[i] != null)
            {
                spawnedObjects[i].transform.Translate(direction * speed * Time.deltaTime);
            }
            else
            {
                spawnedObjects.RemoveAt(i);
            }
        }
    }
}
