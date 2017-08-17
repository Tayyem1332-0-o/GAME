using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lights : MonoBehaviour {
	bool off=false;
	public Text instruct;
	public GameObject lightsob;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay(Collider other)
	{
		if (!off) {
			instruct.text = "PRESS E TO TURN OFF";
			instruct.enabled = (true);
		}
		if (off) {
			instruct.text = "PRESS E TO TURN ON";
			instruct.enabled = (true);
		}
		if (other.gameObject.tag == "Player") 
		{
			if (Input.GetKeyDown (KeyCode.E) && !off) {
				lightsob.SetActive (false);
				off = true;
			} 
			else if (Input.GetKeyDown (KeyCode.E) && off) {
				lightsob.SetActive (true);
				off = false;
			}

		}
	}
	void OnTriggerExit(Collider other)
	{
		

			instruct.enabled = (false);

	}
}
