using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairScript : MonoBehaviour
{
    bool triggered;
    bool hasTriggered;
    bool soundPlayed;

    // Update is called once per frame
    void Update()
    {
        if (triggered)
        {
            if (gameObject.GetComponent<Rigidbody>().transform.localPosition.y >= 0.09f)
            {
                if (!hasTriggered)
                    StartCoroutine(Spooky());
                GetComponent<Rigidbody>().AddForce(transform.up * (0.95f * Mathf.Abs(Physics.gravity.y)));
            }
            else
                GetComponent<Rigidbody>().AddForce(transform.up * (1.05f * Mathf.Abs(Physics.gravity.y)));
        }
    }

    public void PlaySound ()
    {
        if (!soundPlayed)
        {
            soundPlayed = true;
            GetComponent<AudioSource>().Play();
        }
    }

    public void FlyBabyFly()
    {
        if (!hasTriggered)
            triggered = true;
    }

    IEnumerator Spooky()
    {
        hasTriggered = true;
        yield return new WaitForSeconds(3f);
        triggered = false;
        GetComponent<Rigidbody>().isKinematic = false;
        PlaySound();
        GetComponent<Rigidbody>().AddForce(new Vector3(-750f, 100f, 0f));
        GetComponent<Rigidbody>().AddTorque(100f, 0f, 50f);
        yield return new WaitForSeconds(1f);
        PictureScript.eventAllowed = true;
    }
}
