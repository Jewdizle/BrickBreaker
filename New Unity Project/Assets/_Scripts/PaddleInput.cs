using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleInput : MonoBehaviour
{
    public float speed;
    public float clamp;

    void Update()
    {
        MovePaddle(Input.GetAxis("horizontal"));
    }

    public void MovePaddle(float inputAxisInfo)
    {
        Vector3 clampedPosition = gameObject.transform.position + new Vector3(inputAxisInfo * speed, 0, 0);
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, -clamp, clamp);
        gameObject.transform.position = clampedPosition;
    }
}
