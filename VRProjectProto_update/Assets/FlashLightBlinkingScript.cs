using UnityEngine;
using System.Collections;

public class FlashLightBlinkingScript : MonoBehaviour {

	public GameObject light;

	public float randomThreshold;
	public int minThreshold;
	public int maxThreshold;

	public float timer;
	bool isOn;
	int randomFlashes;
	int minFlash = 3;
	int maxflash = 7;
	float betweenFlash = 0.03f;

	float randomIntensity; 
	float minRandomIntesity = 0;
	float maxRandomIntesity = 0.81f;

	// Use this for initialization
	void Start () {
		light.GetComponent<Light> ().intensity = 0.81f;
		newRandom ();
	}

	// Update is called once per frame
	void Update () {
			if (!isOn) {
				timer += Time.deltaTime;

			}
			if (timer > randomThreshold) {
				timer = 0;
				StartCoroutine (flashLights ());
			}
		}


	IEnumerator flashLights(){
		isOn = true;

		for(int i = 1; i < randomFlashes; i++){
			light.GetComponent<Light> ().intensity = 0;
			yield return new WaitForSeconds (betweenFlash);
			light.GetComponent<Light> ().intensity = randomIntensity;
			yield return new WaitForSeconds (betweenFlash);
		}

		light.GetComponent<Light> ().intensity = 0;
		yield return new WaitForSeconds (.1f);
		light.GetComponent<Light> ().intensity = 0.81f;

		newRandom ();

		isOn = false;

	}

	void newRandom ()
	{
		randomThreshold = Random.Range (minThreshold, maxThreshold);
		randomFlashes = Random.Range (minFlash, maxflash);
		randomIntensity = Random.Range (minRandomIntesity, maxRandomIntesity);

	}
}
