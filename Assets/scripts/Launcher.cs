using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public List<Rigidbody> rigidbodies;
    public Vector3 force;
    void Start()
    {
        for (int i = 0; i < rigidbodies.Count; i++) {
            rigidbodies[i].AddForce(force, ForceMode.VelocityChange);
        }
        
    }
} 
