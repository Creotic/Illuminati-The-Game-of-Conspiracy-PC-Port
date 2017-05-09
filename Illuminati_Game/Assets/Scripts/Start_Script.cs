using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Script : MonoBehaviour {

	List<Illuminati> illuminati_Cards = new List<Illuminati>();
	int cards;



	// Use this for initialization
	void Start ()
	{
		
		print ("this is the start of the game");
		illuminati_Cards.Add (new Illuminati ("The Bavarian Illuminati", 10, 10, 9)); 
		illuminati_Cards.Add (new Illuminati ("The Bermuda Triangle", 8, 8, 9));
		illuminati_Cards.Add (new Illuminati ("The Discordian Society", 8, 8, 8));
		illuminati_Cards.Add (new Illuminati ("The Gnomes of Zurich", 7, 7, 12));
		illuminati_Cards.Add (new Illuminati ("The Network", 7, 7, 9));
		illuminati_Cards.Add (new Illuminati ("The Servants of Cthulhu", 9, 9, 7));
		illuminati_Cards.Add (new Illuminati ("The Society of Assassins", 8, 8, 8));
		illuminati_Cards.Add (new Illuminati ("The UFOs", 6, 6, 8));

		//print(illuminati_Cards[1].ToString());
		/*foreach (Illuminati card1 in () {
			print (card.ToString ());
		}*/

	}


	public void backButton ()
	{
		Application.LoadLevel("Main");
	}
	
	public void drawCard ()
	{
		cards = Random.Range(0, illuminati_Cards.Count);
		print(illuminati_Cards[cards].ToString());
		illuminati_Cards.RemoveAt(cards);
	}
}

