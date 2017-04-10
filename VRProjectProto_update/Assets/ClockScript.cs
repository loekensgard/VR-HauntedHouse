using UnityEngine;
using System.Collections;

public class ClockScript : MonoBehaviour {

	AudioSource clockSound;
    public static bool thisIsTheEnd;
    bool theEndHasStarted;
    float defaultVolume;

	// Use this for initialization
	void Start () {
		clockSound = GetComponent<AudioSource> ();
        defaultVolume = 1f - clockSound.volume;
        StartCoroutine (clockPlay());
    }

    void Update ()
    {
        if (theEndHasStarted)
            clockSound.volume = clockSound.volume + (defaultVolume * Time.deltaTime / 5f);
    }

	IEnumerator clockPlay ()
	{
		clockSound.Play();
		yield return new WaitForSeconds (5.9f);
        if (thisIsTheEnd)
            StartCoroutine(clockPlayEnd());
        else
            StartCoroutine(clockPlay());
    }

    IEnumerator clockPlayEnd ()
    {
        clockSound.spatialBlend = 0.25f;
        GetComponent<AudioReverbFilter>().enabled = true;
        theEndHasStarted = true;
        clockSound.Play();
        yield return new WaitForSeconds(5.1f);
        PictureScript.ClockFinished();
    }
}
