using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPotion : MonoBehaviour {

	public Image BrewedPotion;
	public PotionSelection Whatwasbrewed;
	public Text WhatwasbrewedText;
	public InventorySystem BrewingTime;

	// Use this for initialization
	void Start () 
	{
		BrewingTime = GameObject.Find ("Inventory_System").GetComponent<InventorySystem> ();
		BrewingTime.PotionBrewing = false;
		BrewedPotion.sprite = BrewingTime.CurrentPotionCopy.PotionGraphic;
		WhatwasbrewedText.text = BrewingTime.CurrentPotionCopy.PotionName;
		BrewingTime.AddPotion();
		BrewingTime.PotionObtained = true;
	}

}
