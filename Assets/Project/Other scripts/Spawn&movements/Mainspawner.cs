using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainspawner : MonoBehaviour
{
       public GameObject spawnerPrefab; 
    public Transform[] pathPoints; // Точки пути, по которым будет двигаться объект
    public float moveSpeed = 2.0f; // Скорость движения объекта
    public float spawnInterval = 2.0f; // Интервал между созданиями объектов в секундах
    public int Enemycount =  3;

    private void Start()
    {
        StartCoroutine(SpawnAndMove());
    }

    private IEnumerator SpawnAndMove()
    {
        for(int i = 0; i < 3; i ++)
        {
            GameObject spawner = Instantiate(spawnerPrefab, transform.position, transform.rotation);
            SpawnerMover mover = spawner.GetComponent<SpawnerMover>();
            if (mover != null)
            {
                mover.SetPath(pathPoints, moveSpeed);
            }
            yield return new WaitForSeconds(spawnInterval);
        }
    }

}
