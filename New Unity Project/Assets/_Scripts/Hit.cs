using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    AudioSource source;

    private void Start()
    {
        source = gameObject.GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        source.Play();
    }
}
