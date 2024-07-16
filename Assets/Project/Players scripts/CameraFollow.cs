using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; 
    public Vector3 offset; 
    private bool isTargetAlive = true; 

    void Update()
    {
        if (isTargetAlive && target != null)
        {
            transform.position = target.position + offset;
        }
    }

    public void OnTargetDeath()
    {
        isTargetAlive = false;
    }
}
