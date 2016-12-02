using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFlashScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Light>().intensity = 0;
        //StartCoroutine(Blink());
    }


    IEnumerator Blink()
    {
        yield return new WaitForSeconds(2f);
        gameObject.GetComponent<Light>().intensity = 6;
        yield return new WaitForSeconds(0.1f);
        gameObject.GetComponent<Light>().intensity = 0;
        StartCoroutine(Blink());
    }
}
