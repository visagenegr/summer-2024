using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GroundCheck : MonoBehaviour
{
   public int maxJumpCount = 2;
   public int jumpcount = 2;

   public float jumpforce = 10.0f;

   public Collider legs;
   public Rigidbody rigidbody;
    
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space) | Input.GetKeyDown(KeyCode.W)){

        
             if (jumpcount <= 0){
                return;
             }
             jumpcount -= 1;
             rigidbody.AddForce(Vector3.up * jumpforce, ForceMode.VelocityChange);
        }
    }

    void OnTriggerEnter(Collider other ) {
        Debug.Log("Grounded");
        jumpcount = maxJumpCount; 
    }

}
