using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	private string moveInputAxis = "Vertical";//Unity Character Controller Tutorial 
	private string turnInputAxis = "Horizontal";//Unity Character Controller Tutorial 

	public float rotationRate = 360;//Unity Character Controller Tutorial 

	public float moveSpeed = 2;//Unity Character Controller Tutorial 
	
	// Update is called once per frame
	void Update () {
		float moveAxis = Input.GetAxis (moveInputAxis);//Unity Character Controller Tutorial 
		float turnAxis = Input.GetAxis (turnInputAxis);//Unity Character Controller Tutorial 

		ApplyInput (moveAxis, turnAxis);//Unity Character Controller Tutorial 
	}

	private void ApplyInput (float moveInput,//Unity Character Controller Tutorial 
		                     float turnInput)
	{
		Move (moveInput);//Unity Character Controller Tutorial 
		Turn (turnInput);
	}

	private void Move (float input)//Unity Character Controller Tutorial 
	{
		transform.Translate (Vector3.forward * input * moveSpeed);
	}

	private void Turn(float input)//Unity Character Controller Tutorial 
	{
		transform.Rotate (0, input * rotationRate * Time.deltaTime, 0);
	}

}
