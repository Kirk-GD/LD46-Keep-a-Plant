using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverScr : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private bool mouse_over = false;
    public GameObject leaf;
    void Update()
    {
        // if (mouse_over)
        // {
        //     Debug.Log("Mouse Over");
        // }
    }
 
    public void OnPointerEnter(PointerEventData eventData)
    {
        mouse_over = true;
        leaf.SetActive(true);
    }
    
    public void OnPointerExit(PointerEventData eventData)
    {
        mouse_over = false;
        leaf.SetActive(false);
    }
}
