using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFlashScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Light>().intensity = 0;
    }


    public void Blink ()
    {
        StartCoroutine(Blinklight());
    }

    IEnumerator Blinklight()
    {
        gameObject.GetComponent<Light>().intensity = 6;
        yield return new WaitForSeconds(0.1f);
        gameObject.GetComponent<Light>().intensity = 0;
    }
}
