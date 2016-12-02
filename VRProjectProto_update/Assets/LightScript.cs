using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour {
    bool dimUp;
    bool dimDown;
    float time;
    float currentDim;
    float defaultIntensity;
    Light light;

	// Use this for initialization
	void Start () {
        MusicBoxScript.AddLight(gameObject);
        light = GetComponent<Light>();
        defaultIntensity = light.intensity;
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (dimUp)
        {
            light.intensity += defaultIntensity * Time.deltaTime / time;
            if (light.intensity >= defaultIntensity)
            {
                dimUp = false;
                light.intensity = defaultIntensity;
            }
        }
        else if (dimDown)
        {
            light.intensity -= defaultIntensity * Time.deltaTime / time;
            if (light.intensity <= 0)
            {
                dimDown = false;
                light.intensity = 0;
            }
        }
	}

    public void dimUpLights (float dimTime)
    {
        if (!dimDown)
        {
            time = dimTime;
            light.intensity = 0;
            dimUp = true;
        }
    }

    public void dimDownLights(float dimTime)
    {
        if (!dimUp)
        {
            time = dimTime;
            dimDown = true;
        }
    }
}
