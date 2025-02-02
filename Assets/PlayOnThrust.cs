using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayOnThrust : MonoBehaviour
{
    private AudioSource audioSource;

    public UnityEvent onThrust, onStop;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && !audioSource.isPlaying)
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
