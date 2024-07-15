using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject template;
public Vector3 offset; 
public int objectcount;
    void Start()
    {
        for(int i = 0; i < objectcount; i ++) {
            Vector3 newPosition =transform.position + offset * i;
            Instantiate(template, newPosition, Quaternion.identity );
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
