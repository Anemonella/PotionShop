using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalZoneItem : ScriptableObject
{
	public int LocationID;
	public string NameOfLocation;
	public Sprite LocationMAINGraphic;
	public string Location1Name;
	public Sprite Location1Graphic;
	public List<IngredientItem> CommonLocation_1;
	public List<IngredientItem> UncommonLocation_1;
	public List<IngredientItem> RareLocation_1;
	public string Location2Name;
	public Sprite Location2Graphic;
	public List<IngredientItem> CommonLocation_2;
	public List<IngredientItem> UncommonLocation_2;
	public List<IngredientItem> RareLocation_2;
	public string Location3Name;
	public Sprite Location3Graphic;
	public List<IngredientItem> CommonLocation_3;
	public List<IngredientItem> UncommonLocation_3;
	public List<IngredientItem> RareLocation_3;
	public string LocationDescription;
	public int TravelTimeLoc1;
	public int TravelTimeLoc2;
	public int TravelTimeLoc3;
}
