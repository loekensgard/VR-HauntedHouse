using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureFallScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "floor")
            gameObject.GetComponent<AudioSource>().Play();
    }


}
