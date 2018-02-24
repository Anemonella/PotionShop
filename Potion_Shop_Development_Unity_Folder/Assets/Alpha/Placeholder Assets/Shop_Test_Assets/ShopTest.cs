using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopTest : MonoBehaviour 
{
	public Image ItemIcon;
	public Text ItemName;
	public Text ItemPrice;
	public Button BuyButton;

	private SeedPacketItem packet;
	private ShopScrollList scrollList;

	// Use this for initialization
	void Start () 
	{
		BuyButton.onClick.AddListener(HandleClick);
	}

	public void SetUp(SeedPacketItem currentPacket, ShopScrollList currentScrollList)
	{
		packet = currentPacket;
		ItemName.text = packet.Packet_Of;
		ItemPrice.text = packet.PacketPrice.ToString ();
		ItemIcon.sprite = packet.PacketGraphic;

		scrollList = currentScrollList;
	}

	public void HandleClick()
	{
		scrollList.TransferToPlayerInvent (packet);
	}

}
