using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulateNPCList : MonoBehaviour 
{
	//spawning
	public List<GameObject> ListOfNPCs;
	public GameObject NPCGeneric;
	public GameObject NPCUnique;
	public GameObject NPCGenericStorage;
	public GameObject NPCGenericDeploy;
	public GameObject NPCGenericPool;
	public GameObject NPCGenericLocation;
	public GameObject Customer;



	public void CreateNPCGeneric()
	{
		
		NPCGenericStorage = Instantiate(NPCGeneric);
		ListOfNPCs.Add(NPCGenericStorage);

		//NPCGenericStorage.name = ToString(Customer.Name);
		//_list.Add( (GameObject)Instantiate(_gameObject) );
		//NPCGeneric.name = "Generic NPC";
		//ListOfNPCs.Add
		//ListOfNPCs.Add(Resources.Load("GenericNPC", typeof(GameObject)) as GameObject);
		//add prefab to List with elements filled out????
	}

	public void AddToScene()
	{
		NPCGenericDeploy = (ListOfNPCs [Random.Range (0,ListOfNPCs.Count)]);
		Instantiate (NPCGenericDeploy);
		NPCGenericDeploy.tag = "NPC";
		if (GameObject.Find ("Customer_0") != null) 
		{
			//NPCGenericDeploy.name = "Customer_1";
			if (GameObject.Find ("Customer_1") != null) {
				NPCGenericDeploy.name = "Customer_2";
			} else 
			{
				NPCGenericDeploy.name = "Customer_1";
			}
		}
		else
		{
			NPCGenericDeploy.name = "Customer_0";
		}
		NPCGenericDeploy.SetActive(true);
		ListOfNPCs.Remove (NPCGenericDeploy);

		NPCGenericPool = Instantiate (NPCGenericDeploy);
		NPCGenericPool.transform.parent = NPCGenericLocation.transform;
	}


	public void DeleteCustomer ()
	{
		Customer = GameObject.Find ("Customer_0");
	}
}