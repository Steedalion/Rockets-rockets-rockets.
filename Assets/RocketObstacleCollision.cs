using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RocketObstacleCollision : MonoBehaviour
{
    private float threshHold = 4;
    public GameManager gm;
        public CheatKeys cheatKeys;

    public UnityEvent onObstacleCollision, onCorrectLanding;

    
    private void OnCollisionEnter(Collision other)
    {
        if(cheatKeys.collisionDisabled) return;
        if(gm.isGameOver) return;
        // Debug.Log("Collision" + other.impulse);
        string tag = other.gameObject.tag;
        if (tag == "obstacle" || other.impulse.magnitude > threshHold)
        {
            Debug.Log("Collision" + other.impulse);
            onObstacleCollision?.Invoke();
            gameObject.GetComponent<RockerMover>().enabled = false;
            StartCoroutine(CrashSequence(other.impulse.magnitude));
        }
        else if (tag == "finish")
        {
            onCorrectLanding?.Invoke();
            StartCoroutine(LevelComplete());
        }
    }

    private IEnumerator LevelComplete()
    {
        yield return new WaitForSeconds(1);
        Debug.Log("Completed");
        gm.LoadNextScene();
        yield return null;
    }

    private IEnumerator CrashSequence(float magnitude)
    {
        Debug.Log("Crashed");
        gm.GameOver();
        yield return new WaitForSeconds(1);
        gm.RestartScene();
        yield return null;
    }
}