using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFlashScript : MonoBehaviour {
    public GameObject flashSound;
    public GameObject shutterSound;
    public GameObject extraLight;

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Light>().intensity = 0;
    }


    public void Blink ()
    {
        StartCoroutine(Blinklight());
    }

    public void ChargeFlash ()
    {
        flashSound.GetComponent<AudioSource>().Play();
    }

    IEnumerator Blinklight()
    {
        shutterSound.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(0.05f);
        gameObject.GetComponent<Light>().intensity = 2;
        extraLight.GetComponent<Light>().intensity = 1f;
        yield return new WaitForSeconds(0.1f);
        gameObject.GetComponent<Light>().intensity = 0;
        extraLight.GetComponent<Light>().intensity = 0;
    }
}
