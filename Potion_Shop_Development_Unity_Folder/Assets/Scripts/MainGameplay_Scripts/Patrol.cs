using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Patrol : MonoBehaviour {

	public Transform[] points;
	private int destPoint = 0;
	private NavMeshAgent agent;
	private bool destinationReached = false;
	public Patrol P;
	public Patrol_Return PR;
	public GameObject TalkToMe;
	//Animator Anim;

	void Start () {
		agent = GetComponent<NavMeshAgent>();
		P.enabled = true;
		PR.enabled = false;
		// Disabling auto-braking allows for continuous movement
		// between points (ie, the agent doesn't slow down as it
		// approaches a destination point).
		agent.autoBraking = false;
		TalkToMe.gameObject.SetActive (false);
		GotoNextPoint();
	}


	void GotoNextPoint() 
	{
		// Returns if no points have been set up
		if (points.Length == 0)
			return;

		// Set the agent to go to the currently selected destination.
		agent.destination = points[destPoint].position;

		// Choose the next point in the array as the destination,
		// ends update with boolean on reaching final destination.

		if ((destPoint + 1) <= (points.Length - 1))
		{
			destPoint = (destPoint + 1);
		} 
		else 
		{
			//Anim = GetComponent<Animator> ();
			//Anim.Play ("Standing@Loop");
			destinationReached = true;
			P.enabled = false;
			TalkToMe.gameObject.SetActive (true);

		}


	}


	void Update () 
	{
		// Choose the next destination point when the agent gets
		// close to the current one.
		if (!agent.pathPending && agent.remainingDistance < 0.5f && destinationReached == false)
		{
			GotoNextPoint();
		}
			
	}
}