using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByDistance : MonoBehaviour
{
    
    public float destroyDistance = 10.0f; // Расстояние уничтожения

    void Update()
    {
        
        
        GameObject[] destroyableObjects = GameObject.FindGameObjectsWithTag("Destroyable");

        foreach (GameObject obj in destroyableObjects)
        {
            // Вычисляем расстояние до  объекта
             Vector3.Distance(obj.transform.position, Player.playerInstance.transform.position);

            // Уничтожаем объект, если он находится на заданном расстоянии
            if ((Player.playerInstance.transform.position - transform.position).magnitude > destroyDistance)
            {
                Destroy(obj);
            }
        }
    }
}
