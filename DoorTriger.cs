using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriger : MonoBehaviour {

	public Transform door;

	public Vector3 closedPosition = new Vector3 (.437f, -.5f, 0);
	public Vector3 openedPosition = new Vector3 (.437f, .5f, 0);

	public float openSpeed = 5;

	private bool open = false;



	// Update is called once per frame
	void Update ()
	{
		if (open) {
			door.position = Vector3.Lerp (door.position, openedPosition, Time.deltaTime * openSpeed);
		} else {
			door.position = Vector3.Lerp (door.position, closedPosition, Time.deltaTime * openSpeed);
		}
	}

	private void OnTriggerEnter (Collider other)
	{
		if (other.tag == "AccessCard") {
			OpenDoor();
		}
	}

	private void OnTriggerExit (Collider other)
	{
		if (other.tag == "AccessCard") {
			CloseDoor();
		}
	}


	public void CloseDoor ()
	{
		open = false;
	}

	public void OpenDoor(){
		open = true;
	}
}
