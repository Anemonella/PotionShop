using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close : MonoBehaviour 
{
	public InventorySystem Invent;
	public void CloseMoneyGUI()
	{
		Destroy (transform.root.gameObject);
		Invent = GameObject.Find("Inventory_System").GetComponent<InventorySystem> ();
		Invent.RequestComplete = true;
	}

	public void ClosePotionGUI()
	{
		Destroy (transform.root.gameObject);
	}
}
