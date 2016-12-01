﻿using UnityEngine;
using System.Collections;

public class DoorSoundtrigger : MonoBehaviour {

	public GameObject knockSoundContainer;
	public GameObject leftDoor;
	public GameObject rightDoor;

	bool hasPlayed;

	void Start(){
		//rightDoor.GetComponent<Animation> ().Play();
	}


	void OnTriggerEnter (Collider other)
	{
			
		if (!hasPlayed) {
			hasPlayed = true;
			knockSoundContainer.GetComponent<AudioSource> ().Play();
			leftDoor.GetComponent<Animator> ().SetTrigger ("StartAnimation");
			rightDoor.GetComponent<Animator> ().SetTrigger ("StartAnimation");
		
			//leftDoor.GetComponent<Animator> ().SetTrigger ("EndAnimation");
			//rightDoor.GetComponent<Animator> ().SetTrigger ("EndAnimation");

		}
	}

}
