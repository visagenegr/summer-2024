using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosiononcollision : MonoBehaviour
{
   public GameObject explosionPrefab;

    void OnCollisionEnter(Collision collision)
    {
        Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
