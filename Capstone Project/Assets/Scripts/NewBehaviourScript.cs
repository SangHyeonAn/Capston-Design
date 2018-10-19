using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GestureInput();

    }
    void GestureInput()
    {

        if (CompareTag("Player1"))
        {
            if (Input.GetKeyDown(KeyCode.W) == true)
            {

            }
            if (Input.GetKey(KeyCode.W) == true)
            {

                this.transform.Translate(Vector3.forward * 2 * Time.deltaTime);

            }
            if (Input.GetKeyUp(KeyCode.W) == true)
            {

            }
            if (Input.GetKeyDown(KeyCode.S) == true)
            {

            }
            if (Input.GetKey(KeyCode.S) == true)
            {
                this.transform.Translate(Vector3.back * 2 * Time.deltaTime);

            }
            if (Input.GetKeyUp(KeyCode.S) == true)
            {

            }
            if (Input.GetKeyDown(KeyCode.D) == true)
            {

            }
            if (Input.GetKey(KeyCode.D) == true)
            {
                this.transform.Translate(Vector3.right * 2 * Time.deltaTime);

            }
            if (Input.GetKeyUp(KeyCode.D) == true)
            {

            }
            if (Input.GetKeyDown(KeyCode.A) == true)
            {

            }
            if (Input.GetKey(KeyCode.A) == true)
            {

                this.transform.Translate(Vector3.left * 2 * Time.deltaTime);

            }
            if (Input.GetKeyUp(KeyCode.A) == true)
            {

            }


        }
    }
}
