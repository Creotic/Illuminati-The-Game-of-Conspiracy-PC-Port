using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Illuminati : MonoBehaviour {

	string cardName;
	int maxPower;
	int currentPower;
	int income;

	public Illuminati ()
	{
		cardName = "";
		currentPower = 0;
		maxPower = 1;
		income = 0;
	}

	/*Creates the Illuminati cards*/
	public Illuminati (string cardName, int cardCurrentPower, int cardMaxPower, int cardIncome)
	{
		this.cardName = cardName;
		currentPower = cardCurrentPower;
		maxPower = cardMaxPower;
		income = cardIncome;
	}

	/* Retrieves the Illuminati card name*/
	public string getName ()
	{
		return cardName;
	}

	/*Retrieves the Illuminati's current power*/
	public int getCurrentPower ()
	{
		return currentPower;
	}

	/*Retrieves the Illuminati's max power*/
	public int getMaxPower ()
	{
		return maxPower;
	}

	/*Retrieves the Illuminati's income*/
	public int getIncome ()
	{
		return income;
	}

	public string ToString ()
	{
		string print = "You chose " + cardName + " that has an income of " + income 
		+ " with power of " + currentPower + "/" + maxPower + ".";
		return print;
	}

}
