using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] int hitPoints = 10;
    [SerializeField] ParticleSystem hitParticlePrefab;
    [SerializeField] ParticleSystem deathParticlePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnParticleCollision(GameObject other)
    {
        Debug.Log(gameObject.name + " hit by " + other.name);

        ProcessHit();
        if (hitPoints <= 0)
        {
            var vfx = Instantiate(deathParticlePrefab, transform.position, Quaternion.identity);
            vfx.Play();
            Destroy(gameObject);
        }
    }

    void ProcessHit()
    {
        hitParticlePrefab.Play();
        hitPoints -= 1;

    }
}
