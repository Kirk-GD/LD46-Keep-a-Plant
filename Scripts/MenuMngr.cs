using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuMngr : MonoBehaviour
{

    public Animator transitionAnim;
    AudioSource Music;
    public Sprite muted;
    public Sprite unmuted;
    public Button btn;

    void Start()
    {
        
    }
    
    public void PlayGame()
    {
        StartCoroutine(loadScene());
    }
    IEnumerator loadScene()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(0.9f);
        SceneManager.LoadScene("Game");
    }

    public void MuteMusic()
    {
        // Debug.Log("ENTER");
        // if (Music.volume != 0.0f) {
        //     Music.volume = 0.0f;
        //     Debug.Log("MUTE");
        // }
        // if (Music.volume == 0.0f) {
        //     Music.volume = 0.2f;
        //     Debug.Log("UNMUTE");
        // }
        if (Music.mute == true) {
            btn.GetComponent<Image>().sprite = unmuted;
        }
        if (Music.mute == false) {
            btn.GetComponent<Image>().sprite = muted;
        }
        Music.mute = !Music.mute;
        
    }
    void Update()
    {
        Music = GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>();
        if (Music.mute == true) {
            btn.GetComponent<Image>().sprite = muted;
        }
        if (Music.mute == false) {
            btn.GetComponent<Image>().sprite = unmuted;
        }
    }
}
