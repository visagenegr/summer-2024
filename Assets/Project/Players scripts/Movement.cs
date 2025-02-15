using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
   public float speed = 10.0f;

    void Update()
    {
        
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        
        transform.position += new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;
    }
}
