using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Скорость передвижения игрока
    private Rigidbody rbody;

    void Start()
    {
        rbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
       
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

       
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        
        rbody.AddForce(movement * moveSpeed,ForceMode.Acceleration);
    }
}
