﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpEarthRot : MonoBehaviour
{
    float speed = 13f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}
