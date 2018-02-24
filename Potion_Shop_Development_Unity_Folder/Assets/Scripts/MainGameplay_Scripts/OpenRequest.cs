using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenRequest : MonoBehaviour 
{
	public static GameObject NPCRequest;
	public GameObject NPCRequestFab;
	public bool CustomerArea;
	public Collider Area;
	public InventorySystem Invent;
	public Patrol_Return PR;
	public GameObject TalkToMe;

	// Use this for initialization
	void Start () 
	{
		NPCRequest = Instantiate (NPCRequestFab) as GameObject;
		Invent = GameObject.Find("Inventory_System").GetComponent<InventorySystem> ();

		NPCRequest.gameObject.SetActive(false);
		Invent.RequestComplete = false;
		PR.enabled = false;
	}

	void OnMouseDown()
	{
		if(CustomerArea == true)
		{
			NPCRequest.gameObject.SetActive(true);
		}
		else
		{
			return;
		}
	}

	void OnTriggerEnter(Collider Area)
	{
		Debug.Log("Entered");
		CustomerArea = true;
	}

	void OnTriggerExit(Collider Area)
	{
		Debug.Log("Left");
		CustomerArea = false;
	}

	public void Close()
	{
		NPCRequest.gameObject.SetActive(false);
	}

	void Update()
	{
		Invent = GameObject.Find("Inventory_System").GetComponent<InventorySystem> ();
		if(Invent.RequestComplete == true)
		{
			TalkToMe.gameObject.SetActive (false);
			PR.enabled = true;
		}
	}
}
