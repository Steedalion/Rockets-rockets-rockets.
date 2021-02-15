using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheatKeys : MonoBehaviour
{

    public bool collisionDisabled { get; private set; } = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            StartCoroutine(ToggelCollisions());
        }
    }

    IEnumerator ToggelCollisions()
    {

        collisionDisabled =! collisionDisabled;
        // foreach (Collider collider in GetComponentsInChildren<Collider>())
        // {
        //     collider.enabled = false;
        // }
        yield return null;
    }
}
