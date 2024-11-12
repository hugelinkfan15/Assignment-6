/*
* Kayden Miller
* Assignment 5B
* Used to denoted objects as items, and assign them health
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;
    public TargetTracker tracker;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if(health <= 0)
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
