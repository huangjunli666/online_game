﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LookAt : MonoBehaviour
{
    public Transform target;


    void Update()
    {
        if (target != null)
        {
            this.transform.LookAt(target);
        }
    }
}