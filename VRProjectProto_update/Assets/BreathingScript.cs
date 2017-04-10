using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreathingScript : MonoBehaviour {
    bool hasBreathed;
    float timer = 0;
    float random;

	// Use this for initialization
	void Start () {
        random = Random.Range(30f, 60f);
	}
	
	// Update is called once per frame
	void Update () {
        if (!hasBreathed && PictureScript.eventAllowed)
        {
            timer += Time.deltaTime;
            if (timer >= random)
            {
                hasBreathed = true;
                StartCoroutine(Breathe());
            }
        }
	}

    IEnumerator Breathe ()
    {
        PictureScript.eventAllowed = false;
        gameObject.transform.parent = null;
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(8f);
        PictureScript.eventAllowed = true;
    }
}
