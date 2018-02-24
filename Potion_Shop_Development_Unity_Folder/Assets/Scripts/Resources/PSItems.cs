using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public enum TypeofPotion
{
	Medical, Combat, Arcane, Mischief
}

public class PSItems : ScriptableObject
{
	public int PotionID;
	public string PotionName;
	public string PotionDesc;
	public Sprite PotionGraphic;
	public IngredientItem RecipeIngredient1;
	public IngredientItem RecipeIngredient2;
	public IngredientItem RecipeIngredient3;
	public IngredientItem RecipeIngredient4;
	public IngredientItem RecipeIngredient5;
	public List<IngredientItem> Recipe = new List<IngredientItem>();
	public List<string> Requests;
	public int BrewingTime;
	public TypeofPotion Type;
}
