using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleAutoDestroy : MonoBehaviour
{
    private new ParticleSystem particleSystem;

    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
        if (particleSystem == null)
        {
            Debug.LogError("Particle system not found on the object.");
        }
    }

    void Update()
    {
        if (particleSystem != null && !particleSystem.IsAlive())
        {
            Destroy(gameObject);
        }
    }
}