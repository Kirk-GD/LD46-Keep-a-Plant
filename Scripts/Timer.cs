using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text txt;
    public GameObject Plant;
    float s1 = 0f;
    float s2 = 0f;
    float m1 = 0f;
    float m2 = 0f;
    // Start is called before the first frame update
    void Start()
    {
        txt.text = m1.ToString() + m2.ToString() + ":" + s1.ToString() + s2.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Plant != null) {
            s2 += 1f * Time.deltaTime;
            if (s2 >= 9.99f) {
                s2 = 0f;
                s1 += 1f;
            }
            if (s1 >= 5.99f) {
                s1 = 0f;
                m2 += 1f;
            }
            if (m2 >= 9.99f) {
                m2 = 0f;
                m1 += 1f;
            }
            txt.text = ((int)m1).ToString() + " " + ((int)m2).ToString() + " " + ":" + " " + ((int)s1).ToString() + " " + ((int)s2).ToString();
        }
        
    }
}
