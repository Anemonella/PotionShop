using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNPC : MonoBehaviour 
{
	public List<Transform> Spawn;
	public GameObject NPCPrefab;
	public GameObject NPCClone;
	public InventorySystem Check;
	public Patrol_Return PR;

	void Start()
	{
		Check = GameObject.Find ("Inventory_System").GetComponent<InventorySystem> ();
		NPCSpawner();
		Check.NPCSpawned = true;
		PR.enabled = false;
	}

	public void NPCSpawner()
	{
		int NPCclone = UnityEngine.Random.Range (0, Spawn.Count);
		NPCClone = Instantiate(NPCPrefab,Spawn[NPCclone].transform.position, Quaternion.Euler(0,0,0)) as GameObject;
		PR = NPCClone.GetComponentInParent<Patrol_Return>();
		PR.enabled = false;
	
	}

	void Update()
	{
		if(Check.NPCSpawned == true)
		{
			return;
		}
		else
		{
			NPCSpawner();
			Check.NPCSpawned = true;
		}
	}
}
