using UnityEngine;
using System.Collections;

public class JumpScareDoorWayScript : MonoBehaviour {

	public GameObject herman;
	public GameObject light;

	bool hasEntered;

	// Use this for initialization
	void Start () {
		hasEntered = false;
		herman.GetComponent<Renderer> ().enabled = false;
		light.GetComponent<Light> ().intensity = 0;
	}

	void OnTriggerEnter(Collider other){
		if (!hasEntered)
			StartCoroutine (triggerWoosh ());
	}

	IEnumerator triggerWoosh ()
	{
		hasEntered = true;

		herman.GetComponent<Renderer> ().enabled = true;
		light.GetComponent<Light> ().intensity = 1.5f;
		herman.GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds (2f);
		herman.GetComponent<Renderer> ().enabled = false;
		light.GetComponent<Light> ().intensity = 0;
	}
}
