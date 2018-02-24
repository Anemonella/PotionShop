using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTimer : MonoBehaviour {

	public float targetTime;
	public bool TimerEnd;
	public SelectZone Portal;
	//public GameObject Selection;
	public InventorySystem Invent;

	// Use this for initialization
	void Start () 
	{
		Invent = GameObject.Find ("Inventory_System").GetComponent<InventorySystem> ();
		Portal = GameObject.Find ("Portal_GUI").GetComponent<SelectZone> ();
		targetTime = Portal.CurrentTravelTime;

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
		Destroy(gameObject);
		//got bool and timer to work
		//when get home connect progressbar!
	}
}
