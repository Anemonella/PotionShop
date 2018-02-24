using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PotionSelection : MonoBehaviour 
{
	public Image SelectionPotion;
	public Image Ingredient1;
	public Image Ingredient2;
	public Image Ingredient3;
	public Image Ingredient4;
	public Image Ingredient5;
	public Text PotionName;
	public Text PotionDesc;
	public List<PSItems> potionselectionlist = new List<PSItems>();
	private int potionSpot = 0;
	public PSItems CurrentPotion;
	public List<IngredientItem> RecipeIngredients;


	public void NextPotion()
	{
		if (potionSpot < potionselectionlist.Count - 1) 
		{
			potionSpot++;
			SelectionPotion.sprite = potionselectionlist [potionSpot].PotionGraphic;
			Ingredient1.enabled = true;
			Ingredient2.enabled = true;
			Ingredient3.enabled = true;
			Ingredient4.enabled = true;
			Ingredient5.enabled = true;

			if (potionselectionlist [potionSpot].Recipe.Count >= 1) {
				Ingredient1.sprite = potionselectionlist [potionSpot].RecipeIngredient1.IngredientGraphic;
			} 
			else 
			{
				Ingredient1.enabled = false;
			}

			if (potionselectionlist [potionSpot].Recipe.Count  >= 2) 
			{
				Ingredient2.sprite = potionselectionlist [potionSpot].RecipeIngredient2.IngredientGraphic;
			}
			else 
			{
				Ingredient2.enabled = false;
			}

			if (potionselectionlist [potionSpot].Recipe.Count  >= 3) 
			{
				Ingredient3.sprite = potionselectionlist [potionSpot].RecipeIngredient3.IngredientGraphic;
			}
			else 
			{
				Ingredient3.enabled = false;
			}

			if (potionselectionlist [potionSpot].Recipe.Count  >= 4) 
			{
				Ingredient4.sprite = potionselectionlist [potionSpot].RecipeIngredient4.IngredientGraphic;
			}
			else 
			{
				Ingredient4.enabled = false;
			}

			if (potionselectionlist [potionSpot].Recipe.Count  >= 5) 
			{
				Ingredient5.sprite = potionselectionlist [potionSpot].RecipeIngredient5.IngredientGraphic;
			}
			else 
			{
				Ingredient5.enabled = false;
			}

			PotionName.text = potionselectionlist [potionSpot].PotionName;
			PotionDesc.text = potionselectionlist [potionSpot].PotionDesc;
			CurrentPotion = potionselectionlist [potionSpot];
			RecipeIngredients = potionselectionlist [potionSpot].Recipe;

		}
	}

	public void PreviousPotion()
	{
		if (potionSpot > 0) 
		{
			potionSpot--;
			SelectionPotion.sprite = potionselectionlist [potionSpot].PotionGraphic;
			Ingredient1.enabled = true;
			Ingredient2.enabled = true;
			Ingredient3.enabled = true;
			Ingredient4.enabled = true;
			Ingredient5.enabled = true;

			if (potionselectionlist [potionSpot].Recipe.Count >= 1) {
				Ingredient1.sprite = potionselectionlist [potionSpot].RecipeIngredient1.IngredientGraphic;
			} 
			else 
			{
				Ingredient1.enabled = false;
			}

			if (potionselectionlist [potionSpot].Recipe.Count  >= 2) 
			{
				Ingredient2.sprite = potionselectionlist [potionSpot].RecipeIngredient2.IngredientGraphic;
			}
			else 
			{
				Ingredient2.enabled = false;
			}

			if (potionselectionlist [potionSpot].Recipe.Count  >= 3) 
			{
				Ingredient3.sprite = potionselectionlist [potionSpot].RecipeIngredient3.IngredientGraphic;
			}
			else 
			{
				Ingredient3.enabled = false;
			}

			if (potionselectionlist [potionSpot].Recipe.Count  >= 4) 
			{
				Ingredient4.sprite = potionselectionlist [potionSpot].RecipeIngredient4.IngredientGraphic;
			}
			else 
			{
				Ingredient4.enabled = false;
			}

			if (potionselectionlist [potionSpot].Recipe.Count  >= 5) 
			{
				Ingredient5.sprite = potionselectionlist [potionSpot].RecipeIngredient5.IngredientGraphic;
			}
			else 
			{
				Ingredient5.enabled = false;
			}


			PotionName.text = potionselectionlist [potionSpot].PotionName;
			PotionDesc.text = potionselectionlist [potionSpot].PotionDesc;
			CurrentPotion = potionselectionlist [potionSpot];
			RecipeIngredients = potionselectionlist [potionSpot].Recipe;
		}
	}
		
	void Update()
	{
		SelectionPotion.sprite = potionselectionlist [potionSpot].PotionGraphic;
		Ingredient1.enabled = true;
		Ingredient2.enabled = true;
		Ingredient3.enabled = true;
		Ingredient4.enabled = true;
		Ingredient5.enabled = true;
		if (potionselectionlist [potionSpot].Recipe.Count >= 1) {
			Ingredient1.sprite = potionselectionlist [potionSpot].RecipeIngredient1.IngredientGraphic;
		} 
		else 
		{
			Ingredient1.enabled = false;
		}

		if (potionselectionlist [potionSpot].Recipe.Count  >= 2) 
		{
			Ingredient2.sprite = potionselectionlist [potionSpot].RecipeIngredient2.IngredientGraphic;
		}
		else 
		{
			Ingredient2.enabled = false;
		}

		if (potionselectionlist [potionSpot].Recipe.Count  >= 3) 
		{
			Ingredient3.sprite = potionselectionlist [potionSpot].RecipeIngredient3.IngredientGraphic;
		}
		else 
		{
			Ingredient3.enabled = false;
		}

		if (potionselectionlist [potionSpot].Recipe.Count  >= 4) 
		{
			Ingredient4.sprite = potionselectionlist [potionSpot].RecipeIngredient4.IngredientGraphic;
		}
		else 
		{
			Ingredient4.enabled = false;
		}

		if (potionselectionlist [potionSpot].Recipe.Count  >= 5) 
		{
			Ingredient5.sprite = potionselectionlist [potionSpot].RecipeIngredient5.IngredientGraphic;
		}
		else 
		{
			Ingredient5.enabled = false;
		}

		PotionName.text = potionselectionlist [potionSpot].PotionName;
		PotionDesc.text = potionselectionlist [potionSpot].PotionDesc;
		CurrentPotion = potionselectionlist [potionSpot];
		RecipeIngredients = potionselectionlist [potionSpot].Recipe;
	}

}
