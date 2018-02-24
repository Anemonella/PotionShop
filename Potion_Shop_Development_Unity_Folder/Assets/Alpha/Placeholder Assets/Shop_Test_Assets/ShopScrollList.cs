using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopScrollList : MonoBehaviour 
{
	public List<SeedPacketItem> SeedList;
	public Transform contentPanel;
	public MoneySystem CurrentBalance;
	public ShopItemPool ItemPool;
	public InventorySystem Invent;
	public Text MoneyBalance;
	//Money = GameObject.Find("Money_System").GetComponent<MoneySystem> ();
	//public ShopScrollList otherShop;

	// Use this for initialization
	void Start ()
	{
		Invent = GameObject.Find ("Inventory_System").GetComponent<InventorySystem> ();
		CurrentBalance = GameObject.Find ("Money_System").GetComponent<MoneySystem> ();
		MoneyBalance.text = CurrentBalance.Money.ToString();
		RefreshDisplay ();
	}

	void Update()
	{
		MoneyBalance.text = CurrentBalance.Money.ToString();
	}

	private void RefreshDisplay() 
	{
		AddItems ();
		MoneyBalance.text = CurrentBalance.Money.ToString();
	}

	private void AddItems ()
	{
		for (int i = 0; i < SeedList.Count; i++) 
		{
			SeedPacketItem packet = SeedList[i];
			GameObject newItem = ItemPool.GetObject ();
			newItem.transform.SetParent (contentPanel,false);

			ShopTest itemHolder = newItem.GetComponent<ShopTest> ();
			itemHolder.SetUp (packet, this);
		}
	}

	public void TransferToPlayerInvent(SeedPacketItem Item)
	{
		if (CurrentBalance.Money >= Item.PacketPrice) {
			CurrentBalance.SubtractFromBalance (Item.PacketPrice);
			AddSeedPacket (Item);
		} else 
		{
			Debug.Log ("You don't have enough money for that!");
		}
	}

	public void AddSeedPacket(SeedPacketItem PacketToAdd)
	{
		Invent.SeedInventory.Add(PacketToAdd);
	}
		
}
