using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol_Return : MonoBehaviour 
{

	public Transform[] points;
	private int destPoint = 0;
	private NavMeshAgent agent;
	private bool destinationReached = false;
	public InventorySystem Check;
	public Patrol_Return PR;

	void Start () {
		Check = GameObject.Find ("Inventory_System").GetComponent<InventorySystem> ();
		agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
		// Disabling auto-braking allows for continuous movement
		// between points (ie, the agent doesn't slow down as it
		// approaches a destination point).
		agent.autoBraking = false;

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
			destinationReached = true;
			Check.NPCSpawned = false;
			PR.enabled = false;
			Destroy (transform.root.gameObject);
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

		Debug.Log(agent.remainingDistance);
	}
}
