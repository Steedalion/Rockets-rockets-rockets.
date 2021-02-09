using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnThrust : MonoBehaviour
{
    private AudioSource audioSource;
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
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            audioSource.Stop();
        }
    }
}
