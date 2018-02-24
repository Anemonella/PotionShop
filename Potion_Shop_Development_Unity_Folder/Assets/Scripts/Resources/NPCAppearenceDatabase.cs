using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCAppearenceDatabase
{
	static private List<NPCAppearenceStorage> _items;

	static private bool _isDatabaseLoaded = false;

	static private void ValidateDatabase() 
	{
		if (_items == null)
			_items = new List<NPCAppearenceStorage> ();
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
		NPCAppearenceStorage[] resources = Resources.LoadAll<NPCAppearenceStorage> (@"NPCAppearenceStorage");
		foreach (NPCAppearenceStorage item in resources) 
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

	static public NPCAppearenceStorage GetItem(int id) 
	{
		ValidateDatabase ();
		foreach (NPCAppearenceStorage item in _items) 
		{
			if (item.ModelID == id) 
			{
				return ScriptableObject.Instantiate (item) as NPCAppearenceStorage;
			}
		}
		return null;
	}
}
