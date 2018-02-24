using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerEndTest : MonoBehaviour 
{
	public SimpleTimer Timer;
	public GameObject Canvas;
	public GameObject Brewing;
	public Text PotionStage;
	public GameObject TimerPrefab;
	public GameObject timer;
	public Image fillImage;
	public Image background;
	public float Maxtime;
	public float Activetime = 0f;

	// Use this for initialization
	void Start () 
	{
		
		fillImage.fillAmount = 0;
		timer = (GameObject)Instantiate(TimerPrefab,new Vector3(0,0,0),Quaternion.identity);
		Timer = timer.GetComponent<SimpleTimer> ();
		Maxtime = Timer.targetTime;
		//time = Timer.targetTime;
		//Instantiate(TimerPrefab);
		//Timer = GameObject.FindWithTag("Timer").GetComponent<SimpleTimer> ();


	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Maxtime > 0)
		{
			Activetime += Time.deltaTime;
			var percent = Activetime / Maxtime;
			fillImage.fillAmount = Mathf.Lerp(0,1,percent);
			//time += Time.deltaTime;
			//fillImage.fillAmount = time / Timer.targetTime;
		}
	}
		
	void OnMouseDown() 
	{

		if(Timer.TimerEnd == false)
		{
			Debug.Log("potion is still brewing");
			return;
		}

		if(Timer.TimerEnd == true)
		{
			Brewing.gameObject.SetActive(true);
			PotionStage.text = "Potion Done";
			Destroy(background);
			Destroy(fillImage);
			Destroy(Timer);
		}
	}

	public void CloseCanvas() 
	{
		Brewing.gameObject.SetActive(false);
	}
}
