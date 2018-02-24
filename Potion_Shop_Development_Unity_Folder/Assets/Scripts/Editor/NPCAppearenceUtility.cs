using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class NPCAppearenceUtility
{
	[MenuItem("Assets/Create/PotionShop/NPCModel")]
	static public void CreateItem() 
	{
		ScriptableObjectUtility.CreateAsset<NPCAppearenceStorage> ();
	}
}
