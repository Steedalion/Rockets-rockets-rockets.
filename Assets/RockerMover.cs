using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockerMover : MonoBehaviour
{
    private Rigidbody rb;

    private float thrust;
    private const float thrustFactor = 1000f;

    private float torque;
    private const float rotationFactor = 300f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        thrust = Mathf.Clamp(Input.GetAxis("Vertical"),0,1)*thrustFactor*Time.deltaTime;
        rb.AddRelativeForce(Vector3.up*thrust);
        torque = Mathf.Clamp(Input.GetAxis("Horizontal"), -1, 1)*rotationFactor*Time.deltaTime;
        rb.AddTorque(Vector3.back*torque);


    }
}
