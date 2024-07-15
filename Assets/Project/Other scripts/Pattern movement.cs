using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patternmovement : MonoBehaviour
{
    public List<Transform> path;

    int currentTarget = 0;
    public float threshold = 2;

    public float accelerationForce = 20;

    public Rigidbody rbody;

    void FixedUpdate() {
        Vector3 direction = (path[currentTarget].position - transform.position).normalized;
        rbody.AddForce(direction * accelerationForce, ForceMode.Force);
        if ((transform.position - path[currentTarget].position).magnitude < threshold) {
            currentTarget++;
            if (currentTarget >= path.Count) {
                Destroy(gameObject);
            }
        }
    }
}
