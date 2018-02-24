using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SeedPacketUtility
{
	[MenuItem("Assets/Create/PotionShop/Packet")]
	static public void CreateItem() 
	{
		ScriptableObjectUtility.CreateAsset<SeedPacketItem> ();
	}
}
