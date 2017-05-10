using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script should be attached to the card game object to display card's rotation 
/// </summary>
[ExecuteInEditMode]
public class CardRotationScript : MonoBehaviour {

	// parent game object for all the card face graphics
	public RectTransform CardFront;
	// parent game object for all the card back graphics
	public RectTransform CardBack;
	// an empty game object that is placed a bit above the face of the card, in the center
	public Transform targetFace;
	// 3D collider attached 
	public Collider collide;
	//if true, player sees the card Back
	private bool showBack = false;
	
	// Update is called once per frame
	void Update ()
	{
		RaycastHit[] hits;
		hits = Physics.RaycastAll (origin: Camera.main.transform.position,
			direction: (-Camera.main.transform.position + targetFace.position).normalized,
			maxDistance: (-Camera.main.transform.position + targetFace.position).magnitude);
		bool passedColliderOnCard = false;

		foreach (RaycastHit h in hits) {
			if (h.collider == collide)
			{
				passedColliderOnCard = true;
			}
		}

		if (passedColliderOnCard != showBack) {
			//something changed
			showBack = passedColliderOnCard;
			if (showBack) 
			{
				//show back of card
				CardFront.gameObject.SetActive (false);
				CardBack.gameObject.SetActive (true);
			} else 
			{
				//show front of card
				CardFront.gameObject.SetActive (true);
				CardBack.gameObject.SetActive (false);
			}
		}

	}
}
