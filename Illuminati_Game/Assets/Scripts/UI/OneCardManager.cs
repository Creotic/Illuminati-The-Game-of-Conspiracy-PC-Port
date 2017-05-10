using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// holds the refs Images on the card
public class OneCardManager : MonoBehaviour {

    public CardAsset cardAsset;
    public GroupAsset groupAsset;
    public OneCardManager PreviewManager;

    [Header("Image References")]
    public Image CardFace;
    public Image GlowFrontImage;
    public Image GlowBackImage;

    void Awake()
    {
        if (cardAsset != null)
            ReadCardFromAsset();
        if (groupAsset != null)
        ReadGroupCardFromAsset();
    }

    private bool canBePlayedNow = false;
    public bool CanBePlayedNow
    {
        get
        {
            return canBePlayedNow;
        }

        set
        {
            canBePlayedNow = value;
			//GlowFrontImage = value;
        }
    }

    public void ReadCardFromAsset()
    {
        // universal actions for any Card
        // 1) apply tint
        if (cardAsset.characterAsset != null)
        {
       
            CardFace.color = cardAsset.characterAsset.ClassCardTint;
        }
        else
        {
      
            CardFace.color = Color.white;
        }

        // 5) Change the card graphic sprite
        CardFace.sprite = cardAsset.CardImage;
      

        if (PreviewManager != null)
        {
            // this is a card and not a preview
            // Preview GameObject will have OneCardManager as well, but PreviewManager should be null there
            PreviewManager.cardAsset = cardAsset;
			PreviewManager.ReadCardFromAsset();
        }
    }

	public void ReadGroupCardFromAsset ()
	{
		// universal actions for any Card
		// 1) apply tint
		if (groupAsset.characterAsset != null) {
       
			CardFace.color = cardAsset.characterAsset.ClassCardTint;
		} else {
      
			CardFace.color = Color.white;
		}

		// 5) Change the card graphic sprite
		CardFace.sprite = groupAsset.CardImage;
      

		if (PreviewManager != null) {
			// this is a card and not a preview
			// Preview GameObject will have OneCardManager as well, but PreviewManager should be null there
			PreviewManager.groupAsset = groupAsset;
			PreviewManager.ReadGroupCardFromAsset ();
		}
	}
}
