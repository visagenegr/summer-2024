using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update
  public Collider collider;
   public Renderer renderer;

    public void Open () {
    collider.enabled = false;
    renderer.enabled = false;
    }   
   public void Close() {
    collider.enabled = true;
    renderer.enabled = true;


   }
   
    }

