using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafFollowMouse : MonoBehaviour
{
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {   
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePos;

    }
    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "Meteorite") {
            score += 1;
            
        }
    }
}
