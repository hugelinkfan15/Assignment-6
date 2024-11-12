/*
* Kayden Miller
* Assignment 6
* Parent class
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    protected float speed;
    protected int health;

    [SerializeField] protected Weapon weapon;

    protected virtual void Awake()
    {
        weapon = gameObject.AddComponent<Weapon>();
        speed = 5f;
        health = 100;

        weapon.damageBonus = 10;
    }

    protected abstract void Attack();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public abstract void TakeDamage(int amount);

    // Update is called once per frame
    void Update()
    {
        
    }
}
