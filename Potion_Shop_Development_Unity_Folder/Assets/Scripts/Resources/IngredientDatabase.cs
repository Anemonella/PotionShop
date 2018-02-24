using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientDatabase
{
	static private List<IngredientItem> _items;

	static private bool _isDatabaseLoaded = false;

	static private void ValidateDatabase() 
	{
		if (_items == null)
			_items = new List<IngredientItem> ();
		if (!_isDatabaseLoaded)
			LoadDatabase ();
	}

	static public void LoadDatabase() 
	{
		if (_isDatabaseLoaded)
			return;
		_isDatabaseLoaded = true;
		LoadDatabaseForce();

	}

	static public void LoadDatabaseForce() 
	{
		ValidateDatabase ();
		IngredientItem[] resources = Resources.LoadAll<IngredientItem> (@"IngredientItem");
		foreach (IngredientItem item in resources) 
		{
			if (!_items.Contains (item)) 
			{
				_items.Add (item);
			}
		}
	}

	static public void ClearDatabase()
	{
		_isDatabaseLoaded = false;
		_items.Clear ();
	}

	static public IngredientItem GetItem(int id) 
	{
		ValidateDatabase ();
		foreach (IngredientItem item in _items) 
		{
			if (item.IngredientID == id) 
			{
				return ScriptableObject.Instantiate (item) as IngredientItem;
			}
		}
		return null;
	}
}
