using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class behavior : MonoBehaviour
{
    public float speed = 1.0f;
   void Update() {
        if (Input.GetKey(KeyCode.W)) {
        transform.position += new Vector3(0, 0, 1) * speed * Time.deltaTime;    
        }
        if (Input.GetKey(KeyCode.A)) {
            transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S)) {
            transform.position += new Vector3(0, 0, -1) * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Space)) {
            transform.position += new Vector3(0, 2, 0) * speed * Time.deltaTime;
        }
        
       }
   
   }

   