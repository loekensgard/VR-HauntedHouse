using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DongScript : MonoBehaviour {

    AudioSource dingeliDongeliSound;

    // Use this for initialization
    void Start()
    {
        dingeliDongeliSound = GetComponent<AudioSource>();
        StartCoroutine(dongPlay());
    }

    IEnumerator dongPlay()
    {
        yield return new WaitForSeconds(60f);
        dingeliDongeliSound.Play();
        StartCoroutine(dongPlay());
    }
}
