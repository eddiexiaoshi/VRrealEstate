﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : PuppyBaseFSM {


	GameObject[] waypoints;
	int currentWP;

	void Awake ()
	{
		waypoints = GameObject.FindGameObjectsWithTag ("waypoint");
	}


	 // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) 
	{
		base.OnStateEnter (animator, stateInfo, layerIndex);
		currentWP = 0;

	}

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) 
	{
		if (waypoints.Length == 0)
			return;
		if (Vector3.Distance (waypoints [currentWP].transform.position,
			Puppy.transform.position) < accuracy)
		{
			currentWP++;
			if (currentWP >= waypoints.Length) 
			{
				currentWP = 0;
			}
	    }
		//rotate towards target

		var direction = waypoints [currentWP].transform.position - Puppy.transform.position;
		Puppy.transform.rotation = Quaternion.Slerp (Puppy.transform.rotation,
			                            Quaternion.LookRotation (direction), 
			                             rotSpeed * Time.deltaTime);
		Puppy.transform.Translate (0, 0, Time.deltaTime * speed);

	}

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {

	}


}
