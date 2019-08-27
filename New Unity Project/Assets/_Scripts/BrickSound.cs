using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSound : MonoBehaviour
{
    AudioSource source;
    public float destroyTime = 1f;

    private void Start()
    {
        source = gameObject.GetComponent<AudioSource>();
    }
    private void OnTriggerEnter()
    {
        source.Play();
        Destroy(gameObject, destroyTime);
    }
}
