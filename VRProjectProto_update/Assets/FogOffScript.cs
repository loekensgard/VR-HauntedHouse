using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogOffScript : MonoBehaviour {
    static GameObject camera;

	// Use this for initialization
	void Start () {
        camera = gameObject;
	}
	
    public static void FogOff ()
    {
        camera.GetComponent<UnityStandardAssets.ImageEffects.GlobalFog>().enabled = false;
    }
}
