using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewBehaviourScript1 : MonoBehaviour {
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
