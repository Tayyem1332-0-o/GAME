using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class DOOR : MonoBehaviour {

	public Text instruct;
	void OnTriggerStay(Collider other)
	{

		if (other.gameObject.tag == "Player") 
		{
			instruct.enabled = true;
			instruct.text = "PRESS E TO GET TO THE STREET";


			if (Input.GetKeyDown (KeyCode.E) ) {
				SceneManager.LoadScene(1);
			} 
		


		}
	}
	void OnTriggerExit(Collider other)
	{
		instruct.enabled = false;

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
