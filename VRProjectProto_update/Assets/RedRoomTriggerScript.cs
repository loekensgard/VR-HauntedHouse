using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedRoomTriggerScript : MonoBehaviour {
    public GameObject clock;

	void OnTriggerEnter (Collider col)
    {
        if (col.gameObject.tag == "controller")
        {
            MoveClockScript.RedRoomTriggerMove();
            if (MoveClockScript.position == 1)
                Destroy(gameObject);
        }
    }
}
