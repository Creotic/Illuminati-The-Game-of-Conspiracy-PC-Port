using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
/// <summary>
/// Test script 
/// </summary>
public class TextBasedDrawIlluminatiCard : MonoBehaviour {

	List<Illuminatis> illuminati_Cards = new List<Illuminatis>();
	int cards;
	GameObject display;

	// Use this for initialization
	void Start ()
	{
		
		print ("this is the start of the game");
		illuminati_Cards.Add (new Illuminatis ("The Bavarian Illuminati", 10, 10, 9)); 
		illuminati_Cards.Add (new Illuminatis ("The Bermuda Triangle", 8, 8, 9));
		illuminati_Cards.Add (new Illuminatis ("The Discordian Society", 8, 8, 8));
		illuminati_Cards.Add (new Illuminatis ("The Gnomes of Zurich", 7, 7, 12));
		illuminati_Cards.Add (new Illuminatis ("The Network", 7, 7, 9));
		illuminati_Cards.Add (new Illuminatis ("The Servants of Cthulhu", 9, 9, 7));
		illuminati_Cards.Add (new Illuminatis ("The Society of Assassins", 8, 8, 8));
		illuminati_Cards.Add (new Illuminatis ("The UFOs", 6, 6, 8));

		display = GameObject.Find("displayText");
	}
	
	public void drawCard ()
	{
		cards = Random.Range(0, illuminati_Cards.Count);
		print(illuminati_Cards[cards].ToString());
		illuminati_Cards.RemoveAt(cards);
	}
}

