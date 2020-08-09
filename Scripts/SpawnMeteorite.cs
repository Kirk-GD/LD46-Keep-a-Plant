﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMeteorite : MonoBehaviour
{
    public GameObject Meteorite;
    public GameObject Plant;
    float rate = 3f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 4, rate);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    void Spawn()
    {
        // Vector3 pos = new Vector3(Random.Range(-10f, 10f), transform.position.y, 0);
        if (Plant != null) {
            Instantiate(Meteorite, new Vector3(Random.Range(-10f, 10f), transform.position.y, 0), Quaternion.identity);
        }
        rate -= 0.02f;
    }
}
