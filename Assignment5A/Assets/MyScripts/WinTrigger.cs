/*
* Kayden Miller
* Assignment 5B
* Used to trigger win text and scene reload
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public bool won;
    public Text winText;
    public TargetTracker tracker;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player") && tracker.numTargets == 0)
        {
            won = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(won)
        {
            winText.text = "You Win!\nPress R to Restart!";
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
