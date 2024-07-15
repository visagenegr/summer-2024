using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
   public int damage = 50; 
    public float explosionRadius = 5.0f; 
    public float speed = 10.0f; 
    
    public Rigidbody  rbody;

    void Start()
    {
        rbody.AddForce(transform.forward * speed,ForceMode.VelocityChange);
    }

    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(Explode());
    }

    IEnumerator Explode()
    {
        yield return new WaitForSeconds(0.1f); 
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach (Collider hit in colliders)
        {
            EnemyHealth enemy = hit.GetComponent<EnemyHealth>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }
        }
        Destroy(gameObject); 
    }
}
