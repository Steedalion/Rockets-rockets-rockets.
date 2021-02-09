using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketObstacleCollision : MonoBehaviour
{
    private float threshHold = 8;
    public GameManager gm; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        // Debug.Log("Collision" + other.impulse);
        string tag = other.gameObject.tag;
        if (tag == "obstacle" || other.impulse.magnitude > threshHold)
        {
            Debug.Log("Collision" + other.impulse);
        }
        else if (tag == "finish")
        {
            Debug.Log("Completed");
            gm.LoadNextScene();
            
        }
    }
}
