using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    private Rigidbody rb;
    public float ballThrust;
    private bool ballInPlay;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();               
    }

    private void Update()
    {
        if(Input.GetButtonDown("Fire1") && ballInPlay == false)
        {
            transform.parent = null;
            ballInPlay = true;
            rb.isKinematic = false;
            rb.AddForce(ballThrust, ballThrust, 0, ForceMode.Acceleration);
        }
    }
}
