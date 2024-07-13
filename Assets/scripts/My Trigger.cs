using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MyTrigger : MonoBehaviour
{
 void  OnTriggerEnter(Collider other) {
    Debug.Log("Entered trigger");
 }
   void OnTriggerStay(Collider other) {
    Debug.Log("In Trigger!");
   }
   void OnTriggerExit(Collider other) {
    Debug.Log("Left Trigger");
}
}
