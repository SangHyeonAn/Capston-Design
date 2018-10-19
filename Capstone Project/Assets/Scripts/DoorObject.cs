using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorObject : MonoBehaviour {

    public Animation DoorAni;

	// Use this for initialization
	void Start () {
        DoorAni = this.gameObject.GetComponent<Animation>();
    }
	
	// Update is called once per frame
	void Update () {
		

	}
    /*
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("player2"))
        {
            Debug.Log("충돌");
        }
    }
    */
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "player2")
        {
            Debug.Log("충돌");
        }
        
    }
    private void OnCollisionStay(Collision collision)
    {
        if(collision.collider.tag == "player2")
        {

            Debug.Log("충돌2222");
        }
    }


}
