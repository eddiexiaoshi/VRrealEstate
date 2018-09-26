using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(HeldObject))]
[RequireComponent(typeof(HingeJoint))]
public class DoorControl : MonoBehaviour {

	public Transform Parent;

	public float MinRot;
	public float MaxRot;

	void Start()
	{
		JointLimits limits = new JointLimits ();
		limits.min = MinRot;
		limits.max = MaxRot;
		GetComponent<HingeJoint> ().limits = limits;
		GetComponent<HingeJoint> ().useLimits = true;
	}

	void Update()
	{
		if (Parent != null) 
		{
			Vector3 targetDelta = Parent.position - transform.position;
			targetDelta.y = 0;

			float AngleDiff = Vector3.Angle (transform.forward, targetDelta);
			Vector3 cross = Vector3.Cross (transform.forward, targetDelta);
			GetComponent<Rigidbody> ().angularVelocity = cross * AngleDiff * 50f;

		}
	}

	public void Pickup()
	{
		Parent = GetComponent<HeldObject> ().parent.transform;
	}
	public void Drop()
	{
		Parent = null;
	}
}
