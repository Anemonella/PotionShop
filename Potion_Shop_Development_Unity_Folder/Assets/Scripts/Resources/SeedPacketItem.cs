using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedPacketItem : ScriptableObject 
{
	public int PacketID;
	public string Packet_Of;
	public Sprite PacketGraphic;
	public IngredientItem ItemGrown;
	public int TimeToGrow;
	public int PacketPrice;
}
