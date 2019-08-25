using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public static Reset instance;
    public GameObject ball;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        InstantiateBall();
    }

    public void InstantiateBall()
    {
        int angleIndex = Random.Range(0, 2);
        GameObject ballCopy = Instantiate(ball, transform.position, Quaternion.Euler(angleIndex, 0, 0));
    }
}
