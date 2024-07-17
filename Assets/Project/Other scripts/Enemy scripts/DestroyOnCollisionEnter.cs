using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollisionExit : MonoBehaviour
{
     public string targetTag = "Target"; 
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {
            Destroy(gameObject);
        }
    }
}
