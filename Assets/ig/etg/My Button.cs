using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    public Door door;
    void OnCollisionEnter(Collision other) {
        door.Open();
    }
    private void OnCollisionExit(Collision other) {
        door.Close(); 
    }
}
