using UnityEngine;
using System.Collections;
using System.Runtime.CompilerServices;

public class MusicBoxScript : MonoBehaviour {
    public static ArrayList lights;
    public GameObject musicBoxLight;
    bool hasPlayed;

    [MethodImpl(MethodImplOptions.Synchronized)]
    public static void AddLight(GameObject light)
    {
        if (lights == null)
            lights = new ArrayList();
        lights.Add(light);
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void LookingAtYou ()
	{
		if (!hasPlayed)
        {
            hasPlayed = true;
            StartCoroutine(MusicBoxEvent());
		}
	}

    IEnumerator MusicBoxEvent ()
    {
        PictureScript.eventAllowed = false;
        GetComponent<AudioSource>().Play();
        GetComponent<Animator>().SetTrigger("StartAnim");
        musicBoxLight.GetComponent<Light>().enabled = true;
        musicBoxLight.GetComponent<LightScript>().dimUpLights(4f);
        foreach (GameObject l in lights)
            l.GetComponent<LightScript>().dimDownLights(4f);
        yield return new WaitForSeconds(20f);
        musicBoxLight.GetComponent<LightScript>().dimDownLights(4f);
        foreach (GameObject l in lights)
            l.GetComponent<LightScript>().dimUpLights(4f);
        yield return new WaitForSeconds(4f);
        PictureScript.eventAllowed = true;
    }
}
