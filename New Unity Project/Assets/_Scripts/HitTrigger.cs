using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitTrigger : MonoBehaviour
{
    AudioSource source;

    private void Start()
    {
        source = gameObject.GetComponent<AudioSource>();
    }
    private void OnTriggerEnter()
    {
        source.Play();
    }
}
