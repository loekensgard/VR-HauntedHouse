using UnityEngine;
using System.Collections;

public class ClockScript : MonoBehaviour {

	AudioSource clockSound;

	// Use this for initialization
	void Start () {
		clockSound = GetComponent<AudioSource> ();
        StartCoroutine (clockPlay());
    }

	IEnumerator clockPlay ()
	{
		clockSound.Play ();
		yield return new WaitForSeconds (5.9f);
		StartCoroutine(clockPlay ());
	}
}
