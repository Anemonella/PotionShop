using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectZone : MonoBehaviour 
{
	//Main
	public Image SelectedLocation;
	public PortalZoneItem SelectedLocationItem;
	public Text LocationName;

	//Zone 1
	public Image Zone1;
	public Text Zone1Name;

	//Zone 2
	public Image Zone2;
	public Text Zone2Name;

	//Zone 3
	public Image Zone3;
	public Text Zone3Name;

	//Other
	private int locationSpot = 0;
	public List<PortalZoneItem> ListOfAvailableLocations = new List<PortalZoneItem>();
	public Button Zone1Button;
	public Button Zone2Button;
	public Button Zone3Button;
	public GameObject ObtainedRewards;

	//rewards
	public IngredientItem RewardCommon;
	public IngredientItem RewardUncommon;
	public IngredientItem RewardRare;

	//timer
	public InventorySystem Invent;
	public GameObject SelectingLocation;
	public GameObject GatheringIngredients;
	public GameObject ProgressBar;
	public float CurrentTravelTime;


	void Start()
	{
		Invent = GameObject.Find ("Inventory_System").GetComponent<InventorySystem> ();

	}

	public void NextLocation()
	{
		if (locationSpot < ListOfAvailableLocations.Count - 1) 
		{
			locationSpot++;
			SelectedLocation.sprite = ListOfAvailableLocations [locationSpot].LocationMAINGraphic;
			LocationName.text = ListOfAvailableLocations [locationSpot].NameOfLocation;
			Zone1.sprite = ListOfAvailableLocations [locationSpot].Location1Graphic;
			Zone1Name.text = ListOfAvailableLocations [locationSpot].Location1Name;
			Zone2.sprite = ListOfAvailableLocations [locationSpot].Location2Graphic;
			Zone2Name.text = ListOfAvailableLocations [locationSpot].Location2Name;
			Zone3.sprite = ListOfAvailableLocations [locationSpot].Location3Graphic;
			Zone3Name.text = ListOfAvailableLocations [locationSpot].Location3Name;
			SelectedLocationItem = ListOfAvailableLocations [locationSpot];

		}
	}

	public void PreviousLocation()
	{
		if (locationSpot > 0) 
		{
			locationSpot--;
			SelectedLocation.sprite = ListOfAvailableLocations [locationSpot].LocationMAINGraphic;
			LocationName.text = ListOfAvailableLocations [locationSpot].NameOfLocation;
			Zone1.sprite = ListOfAvailableLocations [locationSpot].Location1Graphic;
			Zone1Name.text = ListOfAvailableLocations [locationSpot].Location1Name;
			Zone2.sprite = ListOfAvailableLocations [locationSpot].Location2Graphic;
			Zone2Name.text = ListOfAvailableLocations [locationSpot].Location2Name;
			Zone3.sprite = ListOfAvailableLocations [locationSpot].Location3Graphic;
			Zone3Name.text = ListOfAvailableLocations [locationSpot].Location3Name;
			SelectedLocationItem = ListOfAvailableLocations [locationSpot];
		}
	}


	void Update () 
	{
		SelectedLocation.sprite = ListOfAvailableLocations [locationSpot].LocationMAINGraphic;
		LocationName.text = ListOfAvailableLocations [locationSpot].NameOfLocation;
		Zone1.sprite = ListOfAvailableLocations [locationSpot].Location1Graphic;
		Zone1Name.text = ListOfAvailableLocations [locationSpot].Location1Name;
		Zone2.sprite = ListOfAvailableLocations [locationSpot].Location2Graphic;
		Zone2Name.text = ListOfAvailableLocations [locationSpot].Location2Name;
		Zone3.sprite = ListOfAvailableLocations [locationSpot].Location3Graphic;
		Zone3Name.text = ListOfAvailableLocations [locationSpot].Location3Name;
		SelectedLocationItem = ListOfAvailableLocations [locationSpot];


	}


	public void RewardsZone1 ()
	{
		RewardCommon = SelectedLocationItem.CommonLocation_1 [Random.Range (0,SelectedLocationItem.CommonLocation_1.Count)];
		RewardUncommon = SelectedLocationItem.UncommonLocation_1 [Random.Range (0,SelectedLocationItem.UncommonLocation_1.Count)];
		RewardRare = SelectedLocationItem.RareLocation_1 [Random.Range (0,SelectedLocationItem.RareLocation_1.Count)];
		Debug.Log("Rewarded Selected");
		//Instantiate(ObtainedRewards);
		Gathering();
		CurrentTravelTime = SelectedLocationItem.TravelTimeLoc1;
	}

	public void RewardsZone2 ()
	{
		RewardCommon = SelectedLocationItem.CommonLocation_2 [Random.Range (0,SelectedLocationItem.CommonLocation_2.Count)];
		RewardUncommon = SelectedLocationItem.UncommonLocation_2 [Random.Range (0,SelectedLocationItem.UncommonLocation_2.Count)];
		RewardRare = SelectedLocationItem.RareLocation_2 [Random.Range (0,SelectedLocationItem.RareLocation_2.Count)];
		Debug.Log("Rewarded Selected");
		//Instantiate(ObtainedRewards);
		Gathering();
		CurrentTravelTime = SelectedLocationItem.TravelTimeLoc1;
	}

	public void RewardsZone3 ()
	{
		RewardCommon = SelectedLocationItem.CommonLocation_3 [Random.Range (0,SelectedLocationItem.CommonLocation_3.Count)];
		RewardUncommon = SelectedLocationItem.UncommonLocation_3 [Random.Range (0,SelectedLocationItem.UncommonLocation_3.Count)];
		RewardRare = SelectedLocationItem.RareLocation_3 [Random.Range (0,SelectedLocationItem.RareLocation_3.Count)];
		//Instantiate(ObtainedRewards);
		Gathering();
		CurrentTravelTime = SelectedLocationItem.TravelTimeLoc1;
	}

	public void Gathering()
	{
		SelectingLocation.gameObject.SetActive(false);
		ProgressBar = Instantiate (GatheringIngredients);
		ProgressBar.name = "portalProgress";

	}

	public void AddToPlayerInventPortal(IngredientItem IngredientToAdd)
	{
		Invent.IngredientInventory.Add(IngredientToAdd);
		//instatiate progress bar and timer
	}
}
