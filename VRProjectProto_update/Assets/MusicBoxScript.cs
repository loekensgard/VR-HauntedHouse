using UnityEngine;
using System.Collections;

public class MusicBoxScript : MonoBehaviour {

	bool hasPlayed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void LookingAtYou ()
	{
		if (!hasPlayed) {
			GetComponent<AudioSource> ().Play ();
			GetComponent<Animator> ().SetTrigger("StartAnim");
			hasPlayed = true;
		}
	}
}
