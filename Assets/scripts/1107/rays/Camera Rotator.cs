using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    public float horizontalRotationSpeed=5;
    void Update(){
        float mouseInput = Input.GetAxis("Mouse X");
        if(mouseInput != 0){
            float rotationAngle = horizontalRotationSpeed*mouseInput*Time.deltaTime;
            transform.Rotate(0, rotationAngle, 0);
        }
    }
}
