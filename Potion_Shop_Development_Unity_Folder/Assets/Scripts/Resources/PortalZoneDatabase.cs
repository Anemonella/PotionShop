using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalZoneDatabase
{
	static private List<PortalZoneItem> _items;

	static private bool _isDatabaseLoaded = false;

	static private void ValidateDatabase() 
	{
		if (_items == null)
			_items = new List<PortalZoneItem> ();
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
		PortalZoneItem[] resources = Resources.LoadAll<PortalZoneItem> (@"PortalZoneItem");
		foreach (PortalZoneItem item in resources) 
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

	static public PortalZoneItem GetItem(int id) 
	{
		ValidateDatabase ();
		foreach (PortalZoneItem item in _items) 
		{
			if (item.LocationID == id) 
			{
				return ScriptableObject.Instantiate (item) as PortalZoneItem;
			}
		}
		return null;
	}
}
