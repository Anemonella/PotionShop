using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Complete : MonoBehaviour 
{
	public InventorySystem Check;
	// Use this for initialization
	void Start () 
	{
		Check = GameObject.Find ("Inventory_System").GetComponent<InventorySystem> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Check.PotionObtained == true)
		{
			Destroy (transform.root.gameObject);
		}
	}
}
