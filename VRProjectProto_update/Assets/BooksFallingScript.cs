using System.Collections;
using UnityEngine.Networking;
using UnityEngine;
using System.Runtime.CompilerServices;

public class BooksFallingScript : MonoBehaviour {
    
    public static ArrayList books;
    public GameObject whisperContainer;
    bool hasTriggered;

    [MethodImpl(MethodImplOptions.Synchronized)]
    public static void AddBook (GameObject book)
    {
        if (books == null)
            books = new ArrayList();
        books.Add(book);
    }


    void OnTriggerEnter(Collider other)
    {
        if (!hasTriggered)
        {
            StartCoroutine(WhisperAndPushBooks());
            hasTriggered = true;
        }
    }

    IEnumerator WhisperAndPushBooks ()
    {
        PictureScript.eventAllowed = false;
        whisperContainer.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3f);
        foreach (GameObject b in books)
            b.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(10f, 25f), Random.Range(10f, 25f), 100f));
        yield return new WaitForSeconds(1f);
        PictureScript.eventAllowed = true;
    }


}
