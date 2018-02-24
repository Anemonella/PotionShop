using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObtainedIngredientPortal : MonoBehaviour {

	//Images of Obtained Ingredients
	public Image Ingredient1_Graphic;
	public Image Ingredient2_Graphic;
	public Image Ingredient3_Graphic;

	//Text showing Obtained Ingredients
	public Text Ingredient1_Text;
	public Text Ingredient2_Text;
	public Text Ingredient3_Text;

	//other
	public SelectZone IngredientLocation;

	// Use this for initialization
	void Start () 
	{
		IngredientLocation = GameObject.Find ("Portal_GUI").GetComponent<SelectZone>();
		Ingredient1_Graphic.sprite = IngredientLocation.RewardCommon.IngredientGraphic;
		Ingredient2_Graphic.sprite = IngredientLocation.RewardUncommon.IngredientGraphic;
		Ingredient3_Graphic.sprite = IngredientLocation.RewardRare.IngredientGraphic;
		Ingredient1_Text.text = IngredientLocation.RewardCommon.IngredientName;
		Ingredient2_Text.text = IngredientLocation.RewardUncommon.IngredientName;
		Ingredient3_Text.text = IngredientLocation.RewardRare.IngredientName;

		IngredientLocation.AddToPlayerInventPortal(IngredientLocation.RewardCommon);
		IngredientLocation.AddToPlayerInventPortal(IngredientLocation.RewardUncommon);
		IngredientLocation.AddToPlayerInventPortal(IngredientLocation.RewardRare);

		IngredientLocation.SelectingLocation.SetActive (true);
	
	}
}
