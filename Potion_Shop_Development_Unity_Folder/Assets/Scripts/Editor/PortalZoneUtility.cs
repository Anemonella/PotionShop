using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PortalZoneUtility
{
	[MenuItem("Assets/Create/PotionShop/Zone")]
	static public void CreateItem() 
	{
		ScriptableObjectUtility.CreateAsset<PortalZoneItem> ();
	}
}
