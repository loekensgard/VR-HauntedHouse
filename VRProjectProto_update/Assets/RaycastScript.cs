using UnityEngine;
using System.Collections;

public class RaycastScript : MonoBehaviour {
	public float hoverForce = 12f;
	public GameObject picture;
	public GameObject cube;
	public GameObject womanScriptContainer;
    public GameObject clock;

	bool hasPlayed;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		float theDistance;

		//Debug for å vise hvor raycast er henn når man sjekker scene når spillet har startet
		Vector3 forward = transform.TransformDirection (Vector3.forward) * 10;
		Debug.DrawRay (transform.position, forward, Color.green);

		//raycast hit
		if(Physics.Raycast(transform.position,(forward), out hit)){
			theDistance = hit.distance;
		//	print (theDistance + " " + hit.collider.gameObject.name);


			//hit.transform.gameObject.GetComponent<Rigidbody> ().isKinematic = false;
			//hit.transform.gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.up * hoverForce, ForceMode.Acceleration);

			GameObject other = hit.transform.gameObject;

			if (other.tag == "musicBox" && theDistance < 3f) {
				other.GetComponent<MusicBoxScript> ().LookingAtYou ();
			}

            if(other.tag == "log" && theDistance < 4f)
            {
                other.GetComponent<logScript>().Fly();
            }

			if (other.tag == "pictureTrigger" && theDistance < 5f) {
				hit.transform.gameObject.GetComponent<Rigidbody> ().isKinematic = false;
				if (!hasPlayed) {
					hasPlayed = true;
					hit.transform.gameObject.GetComponent<AudioSource> ().Play ();
				}
			}

			if (other.tag == "stairs") {
				womanScriptContainer.GetComponent<LigthWomanInStair> ().hasLooked = true;
                MoveClockScript.LookingAtStairsMove();
			}

			
		}

	}
}
