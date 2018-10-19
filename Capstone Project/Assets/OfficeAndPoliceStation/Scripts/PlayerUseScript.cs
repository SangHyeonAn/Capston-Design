using UnityEngine;
using System.Collections;

public class PlayerUseScript : MonoBehaviour {

	public float interactDistance = 20f;
    public GameObject PanelControls;
    void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Mouse0))
		{
			Ray ray = new Ray(transform.position, transform.forward);
			RaycastHit hit;
			if(Physics.Raycast(ray, out hit, interactDistance))
			{
				if(hit.collider.CompareTag("Door"))
				{
					hit.collider.transform.parent.GetComponent<DoorScript>().ChangeDoorState();
				}
			}
			
		}
        if (Input.GetKeyDown(KeyCode.Z))
        {
            PanelControls.gameObject.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            PanelControls.gameObject.SetActive(true);
        }
	}
    void Use()
    {
       
    }
}
