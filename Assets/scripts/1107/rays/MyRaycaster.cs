using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyRaycaster : MonoBehaviour
{
    void Update()
    {
       Ray ray = new Ray(transform.position, transform.forward);
       RaycastHit hit;
       if(Physics.Raycast(ray, out hit, 20)){
        Debug.Log(hit.collider.gameObject.name);
       }
       

    }
}
