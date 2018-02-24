using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class portalProgress : MonoBehaviour 
{
	public Image fillImage;
	public Image background;
	public GameObject TimerPrefab;
	public GameObject timer;
	public PortalTimer Timer;
	public float Maxtime;
	public float Activetime = 0f;
	public GameObject Complete;
	public SelectZone Portal;

	void Start () 
	{
		Portal = GameObject.Find ("Portal_GUI").GetComponent<SelectZone> ();
		fillImage.fillAmount = 0;
		timer = (GameObject)Instantiate(TimerPrefab,new Vector3(0,0,0),Quaternion.identity);
		timer.name = "Portal_Timer";
		Timer = timer.GetComponent<PortalTimer> ();
		Maxtime = Portal.CurrentTravelTime;
	}

	void Update () 
	{
		if(Maxtime > 0)
		{
			Activetime += Time.deltaTime;
			var percent = Activetime / Maxtime;
			fillImage.fillAmount = Mathf.Lerp(0,1,percent);
		}
		if(Timer.TimerEnd == true)
		{
			Debug.Log("100%");
			Destroy(background);
			Destroy(fillImage);
			Destroy(Timer);
			Instantiate(Complete);
			Destroy (transform.root.gameObject);
		}
		if(fillImage.fillAmount > 0.25f)
		{
			Debug.Log("25%");
		}
		if(fillImage.fillAmount > 0.5f)
		{
			Debug.Log("50%");
		}
		if(fillImage.fillAmount > 0.75f)
		{
			Debug.Log("75%");
		}


	}
}
