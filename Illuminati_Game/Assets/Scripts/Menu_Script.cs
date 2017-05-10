using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_Script : MonoBehaviour {

	bool done = true;
	int count;

	Button twoPlayers;
	Button threePlayers;

	// Use this for initialization
	void Start () {
		print("this is the main menu");
	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	public void numberOfPlayers ()
	{
		if (twoPlayers = GameObject.Find("2Players").GetComponent<Button>()) {
			print ("2Players");
		} else if (threePlayers = GameObject.Find("3Players").GetComponent<Button>()) {
			print ("3Players");
		}
	}

	public void ChangeScene ()
	{
		Application.LoadLevel("Start");
	}


}
