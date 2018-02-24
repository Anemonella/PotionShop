using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateNPC : MonoBehaviour 
{
	
	public float GenderSelection;


	//Lists
	//MALE
	public List<string> NPCNamesMale;
	//public List<Appearence> NPCAppearenceMale;

	//FEMALE
	public List<string> NPCNamesFemale;
	//public List<Appearence> NPCAppearenceFemale;

	//BOTH
	public List<string> NPCOccupations;
	public List<string> NPCHometowns;


	//Storage
	public string Name;
	public string Occupation;
	public string Hometown;
	public Image Race;
	//public Appearence NPCApperance;

	public bool Info;
	//Make scriptable object

	// Use this for initialization
	//public Outfit

	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void Awake ()
	{
		if(Info == false)
		{
			GenderSelection = Random.Range (0.0f, 1.0f);
			if (GenderSelection <= 0.5f) 
			{
				Debug.Log ("It's a boy");
				Name = NPCNamesMale [Random.Range (0, NPCNamesMale.Count)];
			} 
			else 
			{
				Debug.Log ("It's a girl");
				Name = NPCNamesFemale [Random.Range (0, NPCNamesFemale.Count)];
			}

			Occupation = NPCOccupations [Random.Range (0, NPCOccupations.Count)];
			Hometown = NPCHometowns [Random.Range (0, NPCHometowns.Count)];
			Info = true;
			gameObject.SetActive(false);
		}
		else
		{
			gameObject.SetActive(true);
		}
	}

}
