using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

public class BookScript : MonoBehaviour {

    // Use this for initialization
    void Start () {
        BooksFallingScript.AddBook(gameObject);
	}

    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.tag == "floor")
            gameObject.GetComponent<AudioSource>().Play();
    }
}
