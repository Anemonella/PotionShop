using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateRequests : MonoBehaviour 
{

	public Image NPC_Face;
	public Image Potion_Image;
	public Text NPC_Name;
	public Text NPC_Race;
	public Text NPC_Hometown;
	public Text NPC_Occupation;
	public Text Potion_Name;
	public Text Request_Text;
	public PSItems Potion;

	public List<string> NPC_NameList;
	public List<string> NPC_RaceList;
	public List<string> NPC_OccupationList;
	public List<string> NPC_HometownList;
	public List<PSItems> Requested_Potion;
	public List<Image> NPC_Images;
	public InventorySystem Invent;
	public int MoneyReward;
	public Text RewardText;
	public MoneySystem Money;
	public GameObject Prefab;
	public GameObject EndResult;
	public Button Zone1Button;
	public Button Zone2Button;
	public Button Zone3Button;

	//rewards
	public PortalZoneItem RewardCommon;
	public PortalZoneItem RewardUncommon;
	public PortalZoneItem RewardRare;

	// Use this for initialization
	void Start () 
	{
		MoneyReward = Random.Range (200,1000);
		RewardText.text = MoneyReward.ToString ();
		Invent = GameObject.Find("Inventory_System").GetComponent<InventorySystem> ();
		Money = GameObject.Find("Money_System").GetComponent<MoneySystem> ();
		//NPC Details
		NPC_Name.text = NPC_NameList [Random.Range (0, NPC_NameList.Count)];
		NPC_Race.text = NPC_RaceList [Random.Range (0, NPC_RaceList.Count)];
		NPC_Occupation.text = NPC_OccupationList [Random.Range (0, NPC_OccupationList.Count)];
		NPC_Hometown.text = NPC_HometownList [Random.Range (0, NPC_HometownList.Count)];

		//Potion Details
		Potion = Requested_Potion [Random.Range (0,Requested_Potion.Count)];
		Potion_Name.text = Potion.PotionName;
		Potion_Image.sprite = Potion.PotionGraphic;


		//Request
		Request_Text.text = Potion.Requests [Random.Range (0,Potion.Requests.Count)];
	}
	
	public void GivePotion()
	{
		if(Invent.PotionInventory.Contains(Potion)) 
		{
			Invent.PotionInventory.Remove(Potion);
			Money.AddToBalance(MoneyReward);
			Instantiate (EndResult.transform);
			Destroy (transform.root.gameObject);


		}
		else
		{
			Debug.Log("Potion not in Inventory");
		}
	}


}
