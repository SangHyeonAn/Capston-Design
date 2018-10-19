using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class LookItem : MonoBehaviour,
    IPointerExitHandler,
    IPointerEnterHandler,
    IGvrPointerHoverHandler
    {


	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnLookItemBox(bool isLookAt)
    {
        Debug.Log(isLookAt);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        MoveCtrl.isStopped = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
    
        MoveCtrl.isStopped = false;
    }

    public void OnGvrPointerHover(PointerEventData eventData)
    {
        Debug.Log("Pointer Hover !!");
    }
}
