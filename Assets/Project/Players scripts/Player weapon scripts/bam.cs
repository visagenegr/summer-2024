using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bam : MonoBehaviour
{
    public GameObject projectile;
   public float launchVelocity = 70f;
   void Update()
   {
       if (Input.GetButtonDown("Fire1"))
       {
           GameObject ball = Instantiate(projectile, transform.position, transform.rotation);
           Rigidbody x = ball.GetComponent<Rigidbody>();
           x.AddRelativeForce(new Vector3(0, 0,launchVelocity));
       }
   }
   
}
