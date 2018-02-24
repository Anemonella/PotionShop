using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedPacketDatabase
{
	static private List<SeedPacketItem> _items;

	static private bool _isDatabaseLoaded = false;

	static private void ValidateDatabase() 
	{
		if (_items == null)
			_items = new List<SeedPacketItem> ();
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
		SeedPacketItem[] resources = Resources.LoadAll<SeedPacketItem> (@"SeedPacketItem");
		foreach (SeedPacketItem item in resources) 
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

	static public SeedPacketItem GetItem(int id) 
	{
		ValidateDatabase ();
		foreach (SeedPacketItem item in _items) 
		{
			if (item.PacketID == id) 
			{
				return ScriptableObject.Instantiate (item) as SeedPacketItem;
			}
		}
		return null;
	}
}
