using UnityEngine;
using System.Collections;

public class LigthWomanInStair : MonoBehaviour {

	public GameObject light;
	public GameObject womanLaughSource;
	public GameObject creepyWoman;

	public float randomThreshold;
	public int minThreshold;
	public int maxThreshold;
	public bool hasLooked;

	public float timer;
	bool isOn;
	bool hasLaughed;
	int randomFlashes;
	int minFlash = 3;
	int maxflash = 7;
	float betweenFlash = 0.03f;

	int flashCount = 0;

	// Use this for initialization
	void Start () {
		light.GetComponent<Light> ().intensity = 0;
		newRandom ();
	}
	
	// Update is called once per frame
	void Update () {
		if (PictureScript.eventAllowed && flashCount < 2) {
			if (!isOn && !hasLaughed) {
				timer += Time.deltaTime;

			}
			if (timer > randomThreshold) {
				timer = 0;
				laugh();
			}

			if (!hasLaughed && hasLooked)
				hasLooked = false;

			if (hasLaughed && hasLooked && !isOn)
				StartCoroutine (flashLights ());
		}
	}

	void laugh(){
		isOn = true;

		womanLaughSource.GetComponent<AudioSource>().Play ();

		newRandom ();

		hasLaughed = true;
		isOn = false;
	}

	IEnumerator flashLights ()
	{
      
        isOn = true;
		light.GetComponent<AudioSource> ().Play ();
		for(int i = 1; i < randomFlashes; i++){
			light.GetComponent<Light> ().intensity = 1.5f;
			yield return new WaitForSeconds (betweenFlash);
			light.GetComponent<Light> ().intensity = 0;
			yield return new WaitForSeconds (betweenFlash);
		}

		light.GetComponent<Light> ().intensity = 2f;
		yield return new WaitForSeconds (.1f);
		light.GetComponent<Light> ().intensity = 0;

		hasLaughed = false;
		hasLooked = false;

		flashCount++;
		isOn = false;
       
	}

	void newRandom ()
	{
		randomThreshold = Random.Range (minThreshold, maxThreshold);
		randomFlashes = Random.Range (minFlash, maxflash);
	}
}


