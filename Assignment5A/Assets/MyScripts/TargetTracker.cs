/*
* Kayden Miller
* Assignment 5B
* Used to track how many targets are left to hit
*/

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TargetTracker : MonoBehaviour
{
    public int numTargets;
    public TextMeshProUGUI targLeft;

    // Update is called once per frame
    void Update()
    {
        targLeft.text = (numTargets>0)?"Targets: " + numTargets:"No more Targets\nGet to the House!" ;
        
    }

    public void Hit()
    {
        --numTargets;
    }
}
