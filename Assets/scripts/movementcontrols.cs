using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementcontrols : MonoBehaviour
{
   public Rigidbody rigidbody;
   public int  maxSpeed = 5;
   public float acceleration = 3.0f;

   void Accelerate(Vector3 direction ) {
    float currentSpeed = rigidbody.velocity.magnitude;
    if (currentSpeed < maxSpeed){

    
    rigidbody.AddForce(direction * acceleration, ForceMode.Acceleration);
}
      }
      void Update() {
        if (Input.GetKey(KeyCode.A)){
            Accelerate(Vector3.left);
        }
        if (Input.GetKey(KeyCode.D)){
            Accelerate(Vector3.right);
        }
        if (Input.GetKey(KeyCode.S)){
            Accelerate(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.W)){
            Accelerate(Vector3.back);
        }
      }
}  