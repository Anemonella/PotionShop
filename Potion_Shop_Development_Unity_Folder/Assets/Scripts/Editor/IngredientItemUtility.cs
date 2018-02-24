using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class IngredientItemUtility
{
	[MenuItem("Assets/Create/PotionShop/Ingredient")]
	static public void CreateItem() 
	{
		ScriptableObjectUtility.CreateAsset<IngredientItem> ();
	}
}
