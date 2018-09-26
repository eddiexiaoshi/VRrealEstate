using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeControl : MonoBehaviour {
	public GameObject head;
	public GameObject left;
	public GameObject right;

	//private Vector3 height;

	public float speed = 0.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		float trigger = Input.GetAxis ("ControllerTrigger");

		if (trigger > 0.1f) {

			print ("trigger" + trigger);
			this.transform.position += speed * Time.deltaTime * head.transform.forward;
			this.transform.position = new Vector3 (this.transform.position.x, -0.25f , this.transform.position.z);


		}
}
}
