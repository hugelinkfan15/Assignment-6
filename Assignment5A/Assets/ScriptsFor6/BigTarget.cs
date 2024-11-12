using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigTarget : GenericTarget
{
    // Start is called before the first frame update
    void Start()
    {
        base.Start();

        health = 50f;
    }
}
