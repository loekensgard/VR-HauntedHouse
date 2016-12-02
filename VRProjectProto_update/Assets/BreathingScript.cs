using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreathingScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(Breathe());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Breathe ()
    {
        yield return new WaitForSeconds(30f);
        gameObject.transform.parent = null;
        GetComponent<AudioSource>().Play();
    }
}
