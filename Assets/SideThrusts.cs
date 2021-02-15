using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SideThrusts : MonoBehaviour
{
    private AudioSource audioSource;
    public UnityEvent onThrust, onStop;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) ||Input.GetKeyDown(KeyCode.D) && !audioSource.isPlaying)
        {
            audioSource.Play();
            onThrust?.Invoke();
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            onStop?.Invoke();
            audioSource.Stop();
        }
    }
}

