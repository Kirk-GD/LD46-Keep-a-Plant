using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteorite : MonoBehaviour
{
    public Animator anim;
    public Sprite meteorite;
    public SpriteRenderer s;
    public Rigidbody2D rb;
    public CircleCollider2D c;
    public AudioSource sound;
    ParticleSystem p;
    GameObject plant;
    float speed = 10f;
    bool move = true;
    ShakeCam shake;
    // Start is called before the first frame update
    void Start()
    {
        p = GetComponent<ParticleSystem>();
        shake = GameObject.FindGameObjectWithTag("Mngr").GetComponent<ShakeCam>();

        float theLenth = Random.Range(6f, 10f);
        Vector3 size = new Vector3(theLenth, theLenth, 0);
        transform.localScale = size;

        plant = GameObject.FindGameObjectWithTag("Plant");
        if (plant != null) {
            Vector3 dir = plant.transform.position - transform.position;
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle + 90, Vector3.forward);
            rb.gravityScale = 0f;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (move == true) {
            transform.position += -transform.up * Time.deltaTime * speed;
        }
        if (transform.position.y <= -100 || transform.position.y >= 100 || transform.position.x <= -100 || transform.position.y >= 100) {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D col) {
        move = false;
        c.enabled = false;
        rb.gravityScale = 2f;
        anim.enabled = false;
        s.sprite = meteorite;
        p.Play();
        sound.Play();
        shake.CamShake();
    }
}
