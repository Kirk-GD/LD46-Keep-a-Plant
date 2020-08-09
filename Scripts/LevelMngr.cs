using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMngr : MonoBehaviour
{
    public GameObject plant;
    public GameObject earth;
    public GameObject msg;
    public GameObject msgbg;
    public Animator transitionAnim;
    Earth e;
    float timer = 3f;
    // Start is called before the first frame update
    void Start()
    {
        e = earth.GetComponent<Earth>();
    }

    // Update is called once per frame
    void Update()
    {
        if (plant == null) {
            // Debug.Log("GAME OVER");
            e.speed = 0f;
            msg.SetActive(true);
            msgbg.SetActive(true);
            timer -= 1f * Time.deltaTime;
        }
        if (timer <= 0f) {
            // Cursor.visible = true;
            // SceneManager.LoadScene("Menu");
        }
        if (Input.GetKeyDown(KeyCode.E)) {
            // Cursor.visible = true;
            // SceneManager.LoadScene("Menu");
            StartCoroutine(backToMenu());
        }
        if (Input.GetKeyDown(KeyCode.R)) {
            // SceneManager.LoadScene("Game");
            StartCoroutine(replayLevel());
        }
    }
    IEnumerator replayLevel()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(0.9f);
        SceneManager.LoadScene("Game");
    }
    IEnumerator backToMenu()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(0.9f);
        Cursor.visible = true;
        SceneManager.LoadScene("Menu");
    }
}
