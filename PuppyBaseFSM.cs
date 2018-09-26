using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuppyBaseFSM : StateMachineBehaviour {
	public GameObject Puppy;
	public GameObject opponent;
	public float speed = 2.0f;
	public float rotSpeed = 1.0f;
	public float accuracy = 3.0f;

	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		Puppy = animator.gameObject;
		opponent = Puppy.GetComponent<PuppyAI> ().GetPlayer ();
	}
}
