/*
* Kayden Miller
* Assignment 5B
* Used to denoted objects as items, and assign them health
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularTarget : GenericTarget
{
    protected void Start()
    {
        base.Start();

        health = 10f;
    }
}


