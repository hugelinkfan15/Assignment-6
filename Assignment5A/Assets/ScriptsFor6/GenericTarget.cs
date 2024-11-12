using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GenericTarget : MonoBehaviour, IDamageable
{
    public float health;

    public TargetTracker tracker;
    // Start is called before the first frame update
     protected void Start()
    {
        health = 1f;
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        tracker.Hit();
        Destroy(gameObject);
    }
}
