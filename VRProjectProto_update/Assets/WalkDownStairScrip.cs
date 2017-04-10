using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkDownStairScrip : MonoBehaviour {
    public GameObject stepTwo;
    public GameObject stepThree;
    public GameObject stepFour;

    public void WalkDownStairs ()
    {
        StartCoroutine(Walk());
    }

    IEnumerator Walk ()
    {
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(0.5f);
        stepTwo.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(0.5f);
        stepThree.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(0.5f);
        stepFour.GetComponent<AudioSource>().Play();
    }
}
