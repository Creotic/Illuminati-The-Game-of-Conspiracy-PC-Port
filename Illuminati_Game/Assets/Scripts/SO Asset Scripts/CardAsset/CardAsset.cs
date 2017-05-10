using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Defines the illuminati cards
/// </summary>
public enum Targets
{
    NoTarget, 
    AllGroups, 
    EnemyGroups,
    YourGroups
}

public class CardAsset : ScriptableObject 
{
    // this object will hold the info about the most general card
    [Header("General info")]
    public CharacterAsset characterAsset;  // if this is null, it`s a neutral card
	public Sprite CardImage;
	public int Power;
	public int Income;
	[TextArea(2,3)]
  	public string SpecialAbilities;

	
}
