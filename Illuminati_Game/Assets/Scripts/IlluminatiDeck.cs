using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IlluminatiDeck : MonoBehaviour {

	List<CardAsset> illuminati_Cards = new List<CardAsset>();
	int cards;

	//not done unsure how to apply to assets
	public void drawCard ()
	{
		cards = Random.Range(0, illuminati_Cards.Count);
		//print(illuminati_Cards[cards].ToString());

		illuminati_Cards.RemoveAt(cards);
		//playerOne.Illuminati = cards;
	}
}
