using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningCrawlScript : MonoBehaviour{

    public void RunGirl()
    {
        StartCoroutine(Run());
    }


    IEnumerator Run()
    {
        gameObject.GetComponent<Animator>().SetTrigger("StartAnim");
        yield return new WaitForSeconds(2f);
        gameObject.GetComponent<Animator>().SetTrigger("StopAnim");
        Destroy(gameObject);
    }

    public void PlaySound()
    {
        gameObject.GetComponent<AudioSource>().Play();
    }

}
