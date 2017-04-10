using UnityEngine;

public class FlyingChairsScript : MonoBehaviour {
    public GameObject chairOne;
    public GameObject chairTwo;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnTriggerEnter(Collider other)
    {
        PictureScript.eventAllowed = false;
        chairOne.GetComponent<ChairScript>().FlyBabyFly();
        chairTwo.GetComponent<ChairScript>().FlyBabyFly();
        chairTwo.GetComponent<ChairScript>().PlaySound();
        Destroy(gameObject);
    }
}
