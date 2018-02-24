using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PSItemUtility
{
	[MenuItem("Assets/Create/PotionShop/Potion")]
	static public void CreateItem() 
	{
		ScriptableObjectUtility.CreateAsset<PSItems> ();
	}
}
