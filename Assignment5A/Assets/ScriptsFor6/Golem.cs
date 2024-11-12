/*
* Kayden Miller
* Assignment 6
* child of enemy class
* 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem : Enemy
{
    protected int damage;

    // Start is called before the first frame update
    protected override void Awake()
    {
        base.Awake();

        health = 120;

        GameManager.Instance.score = 4;
        
    }

    protected override void Attack()
    {
        Debug.Log("Golem Attacks");
    }

    public override void TakeDamage(int amount)
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
