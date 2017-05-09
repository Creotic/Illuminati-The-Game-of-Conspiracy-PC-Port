using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Script : MonoBehaviour {

	

	// Use this for initialization
	void Start () {
		print("this is the main menu");
	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	public void ChangeScene ()
	{
		Application.LoadLevel("Start");
	}


}
