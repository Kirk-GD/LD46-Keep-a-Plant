using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    GameObject plant;
    // Start is called before the first frame update
    void Start()
    {
        plant = GameObject.FindGameObjectWithTag("Plant");
    }

    // Update is called once per frame
    void Update()
    {
        if (plant != null) {
            transform.position = new Vector3(plant.transform.position.x, plant.transform.position.y, transform.position.z);
        }
    }
}
