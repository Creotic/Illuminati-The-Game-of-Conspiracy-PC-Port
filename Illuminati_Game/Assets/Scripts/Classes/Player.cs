using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	string playerIlluminati;
	int playerIncome;
	int totalPowerStructure;

	public Player()
	{
		playerIlluminati = "";
		playerIncome = 0;
		totalPowerStructure = 0;
	}

	public Player (string illuminati, int income, int totalPower)
	{
		playerIlluminati = illuminati;
		playerIncome = income;
		totalPowerStructure = totalPower;	
	}

	/*Retrieves player number*/
	public string getPlayerIlluminati()
	{
		return playerIlluminati;
	}

	/*Retrieves player's income*/
	public int getPlayerIncome ()
	{	
		return playerIncome;
	}

	/*Retrieves player's total power structure*/
	public int getTotalPower ()
	{
		return totalPowerStructure;
	}

	public void setPlayer (string illuminati, int income, int totalPower)
	{
		playerIlluminati = illuminati;
		playerIncome = income;
		totalPowerStructure = totalPower;	
	}

	/*Sets player number*/
	public void setPlayerIlluminati (string illuminati)
	{
		playerIlluminati = illuminati;
	}

	/*Sets player income*/
	public void setPlayerIncome (int income)
	{
		playerIncome = income;
	}

	/*Sets player number*/
	public void setPowerStructure (int totalPower)
	{
		totalPowerStructure = totalPower;
	}

	public string ToString ()
	{
		string print = "You chose " + playerIlluminati + " that has an income of " + playerIncome 
		+ " with total power structure of " + totalPowerStructure +  ".";
		return print;
	}

}
