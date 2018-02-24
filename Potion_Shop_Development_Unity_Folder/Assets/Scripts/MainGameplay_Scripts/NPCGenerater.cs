using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCGenerater : MonoBehaviour 
{
	public List<GameObject> HeadList = new List<GameObject>();
	public List<GameObject> BodyList = new List<GameObject>();
	public static GameObject NPCHead;
	public static GameObject NPCBody;
	public GameObject NPCContainer;
	public Transform NPCLocation;
	public bool NPC_in_Scene;

	// Use this for initialization
	void Start () 
	{
		AddNPC();
		NPC_in_Scene = true;
	}

	public void AddNPC ()
	{
		int NPChead = UnityEngine.Random.Range (0, HeadList.Count);
		NPCHead = Instantiate (HeadList [NPChead], transform);
		NPCHead.transform.SetParent (NPCContainer.transform);

		int NPCbody = UnityEngine.Random.Range(0,BodyList.Count);
		NPCBody=Instantiate(BodyList[NPCbody],transform);
		NPCBody.transform.SetParent (NPCContainer.transform);
	}

	void Update () 
	{
		if(NPC_in_Scene == true)
		{
			return;
		}

		if(NPC_in_Scene == false)
		{
			AddNPC();
		}
	}
}
