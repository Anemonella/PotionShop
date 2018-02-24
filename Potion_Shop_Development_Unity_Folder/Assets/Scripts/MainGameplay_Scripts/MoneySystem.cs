using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneySystem : MonoBehaviour 
{
	public int Money;
	public Text Balance;

	void Start () 
	{
		Money = 0;
		Balance.text = Money.ToString ();
	}

	public void AddToBalance(int Add)
	{
		Money += Add;
	}

	public void SubtractFromBalance(int Subtract)
	{
		if (Money - Subtract < 0) 
		{
			Debug.Log("Can't buy that right now");

		}
		else
		{
			Money -= Subtract;	
		}
	}
	void Update () 
	{
		Balance.text = Money.ToString ();
	}
}
