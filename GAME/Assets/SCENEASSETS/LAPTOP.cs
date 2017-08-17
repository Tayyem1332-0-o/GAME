using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LAPTOP : MonoBehaviour {
	Animator anim;
	public Text instruct;
	bool closed=false;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}

	void OnTriggerStay(Collider other)
	{

		if (other.gameObject.tag == "Player") 
		{

			if (!closed) {
				instruct.text = "PRESS E TO CLOSE";
				instruct.enabled = (true);
			}
			if (closed) {
				instruct.text = "PRESS E TO OPEN";
				instruct.enabled = (true);
			}
			if (Input.GetKeyDown (KeyCode.E) && !closed) {
				anim.SetBool ("CLOSE", true);
				anim.SetBool ("OPEN", false);
				closed = true;
			} 
			else if (Input.GetKeyDown (KeyCode.E) && closed) {
				anim.SetBool ("CLOSE", false);
				anim.SetBool ("OPEN",true );
				closed = false;
			}

			}
	}
	void OnTriggerExit(Collider other)
	{


		instruct.enabled = (false);

	}

}
