using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillation : MonoBehaviour
{
    [Range(-1, 1)] public float offest;
    [Min(0.1f)] [Range(0.2f, 10)] public float period;
    
    public Vector3 endPosition;

    private Vector3 originalPosition;
    // Start is called before the first frame update
    void Start()
    {
        originalPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(period <= Mathf.Epsilon) return;
        float current =  Time.time / period * Mathf.PI * 2;
        offest = Mathf.Sin(current);
        gameObject.transform.position = originalPosition + offest * endPosition;
    }
}
