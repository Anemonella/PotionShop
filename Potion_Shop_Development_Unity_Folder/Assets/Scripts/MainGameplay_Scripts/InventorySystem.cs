using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySystem : MonoBehaviour
{
	//lists
	public List<PSItems> PotionInventory = new List<PSItems>();
	public List<PSItems> FullPotionInventory = new List<PSItems>();
	public List<IngredientItem> IngredientInventory = new List<IngredientItem>();
	public List<IngredientItem> FullIngredientInventory = new List<IngredientItem>();
	public List<SeedPacketItem> SeedInventory = new List<SeedPacketItem> ();
	public List<SeedPacketItem> FullSeedInventory = new List<SeedPacketItem> ();

	//other
	public PotionSelection PotionSelectionScript;
	public Text MentorText;
	public bool PotionBrewing;
	public GameObject ProgressBar;
	public bool PotionObtained;
	public PSItems CurrentPotionCopy;
	public bool RequestComplete;
	public bool NPCSpawned;

	//GUI gameobjects [if // means not made yet]
	public GameObject Portal;
	public GameObject GeneralStore;
	//public GameObject BlackSmith;
	//public GameObject Tailor;
	public GameObject Brewing;
	//public GameObject GoingOut;
	//public GameObject PauseMenu;
	public GameObject CheckPotion;
	public GameObject checkPotion;
	public OpenBrewingGUI brewStat;

	public GameObject portalProgress;

	void Start()
	{
		PotionSelectionScript = GameObject.Find ("Brewing_GUI").GetComponent<PotionSelection> ();
		Brewing.gameObject.SetActive(false);
		PotionObtained = true;
		CurrentPotionCopy = PotionSelectionScript.CurrentPotion;
		RequestComplete = false;
		Portal.gameObject.SetActive (false);
		GeneralStore.gameObject.SetActive(false);
		brewStat = GameObject.Find ("Brewing_Station").GetComponent<OpenBrewingGUI>();
	}

	void Update()
	{
		CurrentPotionCopy = PotionSelectionScript.CurrentPotion;
	}
		

	public void AddIngredient(IngredientItem item)
	{
		IngredientInventory.Add (item);
	}

	public void AddIngredientsCheat(int number)
	{
		IngredientInventory.Add(FullIngredientInventory [number]);
	}

	public void RemoveIngredient(int number)
	{
		IngredientInventory.Remove(PotionSelectionScript.RecipeIngredients [number]);
	}

	public void CheckIngredient()
	{
		PotionSelectionScript = GameObject.Find ("Brewing_GUI").GetComponent<PotionSelection> ();
		Debug.Log ("Checking Potion");
		List<IngredientItem> IngredientInventoryThrowAway = new List<IngredientItem>();
	//	IngredientInventoryThrowAway.Clear ();
		//IngredientInventoryThrowAway = IngredientInventory;

		for (int i = 0; i < IngredientInventory.Count; i++) 
		{
			IngredientInventoryThrowAway.Add (IngredientInventory [i]);
		}



		int Ingredients = 0;
		for (int a = 0; a < PotionSelectionScript.RecipeIngredients.Count; a++) 
		{
			for (int b = 0; b < IngredientInventoryThrowAway.Count; b++) 
			{
				if (IngredientInventoryThrowAway[b].IngredientID == PotionSelectionScript.RecipeIngredients[a].IngredientID)
				{
					IngredientInventoryThrowAway.RemoveAt (b);
					Ingredients++;
				}
				if (Ingredients == PotionSelectionScript.RecipeIngredients.Count) 
				{
					break;
				}
			}
		}
		Debug.Log (Ingredients.ToString ());
		if (Ingredients == PotionSelectionScript.RecipeIngredients.Count)
		{
			//Instantiate(EndResult);
			//AddPotion();
			for (int a = 0; a <PotionSelectionScript.RecipeIngredients.Count; a++)
			{
				if(PotionSelectionScript.RecipeIngredients.Count >= 1)
				{
					RemoveIngredient (0);
				}

				if(PotionSelectionScript.RecipeIngredients.Count >= 2)
				{
					RemoveIngredient (1);
				}

				if(PotionSelectionScript.RecipeIngredients.Count >= 3)
				{
					RemoveIngredient (2);
				}

				if(PotionSelectionScript.RecipeIngredients.Count >= 4)
				{
					RemoveIngredient (3);
				}

				if(PotionSelectionScript.RecipeIngredients.Count >= 5)
				{
					RemoveIngredient (4);
				}

				if (Ingredients == PotionSelectionScript.RecipeIngredients.Count) 
				{
					break;
				}
			}
			PotionBrewing = true;
			PotionObtained = false;
			Instantiate (ProgressBar);
			checkPotion = Instantiate (CheckPotion);
			checkPotion.name = "CheckPotion";
			brewStat.CheckPotion = checkPotion;
			Debug.Log ("Potion has been brewed");

		}
	
		if(Ingredients < PotionSelectionScript.RecipeIngredients.Count) 
		{
			MentorText.text = "You don't have the ingredeints to make that potion right now!";
			Debug.Log ("Potion couldn't be made");
		}

	}
	public void AddPotion()
	{
		PotionInventory.Add (PotionSelectionScript.CurrentPotion);
		Debug.Log ("Add Potion");
	}

	public void RemovePotion(int number)
	{
		PotionInventory.Remove (FullPotionInventory [number]);
	}

	public void OpenPortal()
	{
		Portal.gameObject.SetActive (true);
		portalProgress.SetActive (true);

	}
	public void ClosePortal()
	{
		Portal.gameObject.SetActive (false);
		if (GameObject.Find ("portalProgress") != null) 
		{
			portalProgress = GameObject.Find ("portalProgress");
			portalProgress.SetActive (false);
		}


	}

	public void OpenGeneralStore()
	{
		GeneralStore.gameObject.SetActive(true);
	}

	public void CloseGeneralStore()
	{
		GeneralStore.gameObject.SetActive(false);
	}

	public void IngredientCheat()
	{
		AddIngredientsCheat(1);
		AddIngredientsCheat(2);
		AddIngredientsCheat(3);
		AddIngredientsCheat(4);
		AddIngredientsCheat(5);

	}

	public void CloseBrewingGUI()
	{
		
		Brewing.gameObject.SetActive(false);
	}

}
