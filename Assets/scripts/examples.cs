using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class examples : MonoBehaviour
{
    void Start() {
        //called on creation

    }
    void Update(){
        //called every frame

    void FixedUpdate(){
        //caled every fixed tick
        }
    }
    void onDestroy(){
        //called on destroy
    }

    void onDisable(){
    Debug.Log("Component disabled");

    }
    void onEnable(){
        Debug.Log("Component Enabled");
    }
}
