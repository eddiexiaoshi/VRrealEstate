using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuppyAI : MonoBehaviour {

	Animator anim;

	public GameObject player;
	public GameObject heart;
	public GameObject mouth;

	public GameObject GetPlayer ()
	{
		return player;
	}

	void Enjoy()
	{
		GameObject l = Instantiate (heart, mouth.transform.position, mouth.transform.rotation);
		l.GetComponent<Rigidbody> ().AddForce (mouth.transform.forward * 500);
	}

	public void StopEnjoy()
	{
		CancelInvoke ("Enjoy");
	}

	public void StartEnjoy()
	{
		InvokeRepeating ("Enjoy", 0.5f, 0.5f);
	}


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		anim.SetFloat ("distance", Vector3.Distance(transform.position,player.transform.position));
	}
}
