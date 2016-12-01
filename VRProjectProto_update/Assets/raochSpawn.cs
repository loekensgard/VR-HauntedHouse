using UnityEngine;
using System.Collections;

public class raochSpawn : MonoBehaviour {

	public GameObject roach;
	GameObject spawn;
	private bool spawned;

	// Use this for initialization
	void Start () {
		//roach = GetComponent<GameObject> ();

	}
	
	// Update is called once per frame
	void Update () {

		if (!spawned) {
			spawn = Instantiate (roach, Vector3.zero,Quaternion.identity) as GameObject;
			spawn.transform.parent = transform;
			spawn.transform.localPosition = Vector3.zero;
			spawned = true; 
		}
	}


}
