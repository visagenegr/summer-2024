using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyshooter : MonoBehaviour
{
    public GameObject enemyBulletPrefab; 
    public Transform firePoint;
    public float fireRate = 1.0f; 
    public float bulletSpeed = 10.0f; 

    private Transform player; 
    private float nextFireTime = 0f;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player")?.transform;
        if (player != null)
        {
            AimAndShoot();
        }
    }

    void Update()
    {
        if (player != null)
        {
            AimAndShoot();
        }
    }

    void AimAndShoot()
    {
        // Повернуть противника в сторону игрока
        Vector3 direction = (player.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);

        // Стрельба
        if (Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + 1f / fireRate;
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(enemyBulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = firePoint.forward * bulletSpeed;
        }
    }
}
