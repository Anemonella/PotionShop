using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PSItemsDatabase 
{
	static private List<PSItems> _items;

	static private bool _isDatabaseLoaded = false;

	static private void ValidateDatabase() 
	{
		if (_items == null)
			_items = new List<PSItems> ();
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
		PSItems[] resources = Resources.LoadAll<PSItems> (@"PSItems");
		foreach (PSItems item in resources) 
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

	static public PSItems GetItem(int id) 
	{
		ValidateDatabase ();
		foreach (PSItems item in _items) 
		{
			if (item.PotionID == id) 
			{
				return ScriptableObject.Instantiate (item) as PSItems;
			}
		}
		return null;
	}
}
