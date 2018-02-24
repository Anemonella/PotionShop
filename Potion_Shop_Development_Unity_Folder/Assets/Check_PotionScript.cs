using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Check_PotionScript : MonoBehaviour 
{
	public Image fillImage;
	public Image background;
	//public GameObject TimerPrefab;
	public GameObject timer;
	public SimpleTimer Timer;
	public float Maxtime;
	public float Activetime = 0f;
	public InventorySystem BrewingTime;

	//potion
	public Image BrewingPotion;
	public Text BrewingPotionName;

	void Start () 
	{
		BrewingTime = GameObject.Find ("Inventory_System").GetComponent<InventorySystem> ();
		fillImage.fillAmount = 0;
		timer = GameObject.Find ("Potion_Timer");
		Timer = timer.GetComponent<SimpleTimer> ();
		Maxtime = BrewingTime.CurrentPotionCopy.BrewingTime;
		BrewingPotion.sprite = BrewingTime.CurrentPotionCopy.PotionGraphic;
		BrewingPotionName.text = BrewingTime.CurrentPotionCopy.PotionName;

	}

	void Update () 
	{
		if(Maxtime > 0)
		{
			Activetime = Timer.targetTime;
			var percent = Activetime / Maxtime;
			fillImage.fillAmount = Mathf.Lerp(1,0,percent);
		}
		if(Timer.TimerEnd == true)
		{
			Destroy(gameObject);
		}
			
	}

	public void CloseCheckPotionGUI()
	{
		gameObject.SetActive (false);
	}

}
