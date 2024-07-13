using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerator : MonoBehaviour
{
    public Rigidbody rbody;


    void FixedUpdate()
    {
        MonthsEnum myMonth = (MonthsEnum)10;
         Debug.Log((int)myMonth);
        rbody.AddForce(Vector3.up, ForceMode.VelocityChange);
    }
}
