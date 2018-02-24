using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenBrewingGUI : MonoBehaviour 
{
	public GameObject BrewingGUI;
	public Text MentorText;
	public InventorySystem BrewingTime;
	public GameObject EndResult;
	public GameObject CheckPotion;

	void Start () 
	{
		BrewingTime = GameObject.Find ("Inventory_System").GetComponent<InventorySystem> ();
		//CheckPotion = GameObject.Find ("CheckPotion");
		//CheckPotion.gameObject.SetActive (false);
	}

	void OnMouseDown()
	{
		if (BrewingTime.PotionBrewing == true) 
		{
			CheckPotion.gameObject.SetActive (true);
		}
		if (BrewingTime.PotionBrewing == false) 
		{
			if(BrewingTime.PotionObtained == false)
			{
				Instantiate(EndResult);
				BrewingTime.PotionObtained = true;
			}
			else
			{
				BrewingGUI.gameObject.SetActive(true);
				MentorText.text = "Well then, what shall we brew today?";	
			}
		}
	}

	public void CloseBrewingGui()
	{
		BrewingGUI.gameObject.SetActive(false);
	}
}
