﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        GM.instance.LoseLife();

    }
}
