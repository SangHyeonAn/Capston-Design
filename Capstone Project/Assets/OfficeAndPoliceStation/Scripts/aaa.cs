using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class aaa : MonoBehaviour {

    public Animator CameraObject;

    public GameObject PanelControls;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void use()
    {

    }
    void exit()
    {
        PanelControls.gameObject.SetActive(false);
    } 
}
