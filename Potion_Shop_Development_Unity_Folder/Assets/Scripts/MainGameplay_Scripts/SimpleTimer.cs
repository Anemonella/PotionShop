using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SimpleTimer: MonoBehaviour {

	public float targetTime;
	public bool TimerEnd;
	public PotionSelection PotionSelectionScript;
	public GameObject Brewing;
	public InventorySystem BrewingTime;

	void Start ()
	{
		TimerEnd = false;
		BrewingTime = GameObject.Find ("Inventory_System").GetComponent<InventorySystem> ();
		Brewing = GameObject.Find ("Brewing_GUI");
		targetTime = BrewingTime.CurrentPotionCopy.BrewingTime;
		Brewing.gameObject.SetActive (false);
	}

	void Update(){

		targetTime -= Time.deltaTime;

		if (targetTime <= 0.0f)
		{
			timerEnded();
		}

	}

	void timerEnded()
	{
		
		TimerEnd = true;
		BrewingTime.PotionBrewing = false;
		Destroy(gameObject);
		//got bool and timer to work
		//when get home connect progressbar!
	}


}